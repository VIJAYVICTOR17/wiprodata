import { useState } from "react";
import DeviceService from "../Services/DeviceService";

const GetDeviceById = ({ onBack }) => {
  const deviceService = DeviceService();
  const [deviceId, setDeviceId] = useState("");
  const [device, setDevice] = useState(null);
  const [message, setMessage] = useState("");

  const handleFetch = async (e) => {
    e.preventDefault();
    if (!deviceId) {
      setMessage("❌ Please enter a DeviceId.");
      return;
    }

    try {
      const data = await deviceService.getDeviceById(Number(deviceId));
      console.log("Device response:", data); // ✅ Check what backend sends
      if (data) {
        setDevice(data);
        //setMessage("✅ Device found!");
      } else {
        setDevice(null);
        setMessage("⚠️ Device not found.");
      }
    } catch (err) {
      console.error("Error fetching device:", err.response || err);
      const errorMsg = err.response?.data
        ? JSON.stringify(err.response.data)
        : err.message;
      setMessage(`❌ Failed to fetch device: ${errorMsg}`);
      setDevice(null);
    }
  };

  return (
    <div style={{ padding: "20px", display: "flex", flexDirection: "column", alignItems: "center" }}>
      <h2>Get Device by ID</h2>

      <form onSubmit={handleFetch} style={{ display: "flex", flexDirection: "column", gap: "10px" }}>
        <input
          type="number"
          placeholder="Enter DeviceId"
          value={deviceId}
          onChange={(e) => setDeviceId(e.target.value)}
          required
          style={{ padding: "6px" }}
        />
        <button type="submit" style={{ padding: "4px 20px",color : "green", cursor: "pointer" }}>Fetch Device</button>
      </form>

      {message && <p style={{ marginTop: "10px" }}>{message}</p>}

      {device && (
        <table style={{ marginTop: "20px", borderCollapse: "collapse", width: "90%" }}>
          <thead>
            <tr style={{ backgroundColor: "#4CAF50", color: "#fff" }}>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceId</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceName</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceType</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>Location</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>UserId</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td style={{ border: "1px solid #ddd", padding: "8px" }}>{device.DeviceId || device.deviceId || "-"}</td>
              <td style={{ border: "1px solid #ddd", padding: "8px" }}>{device.DeviceName || device.deviceName || "-"}</td>
              <td style={{ border: "1px solid #ddd", padding: "8px" }}>{device.DeviceType || device.deviceType || "-"}</td>
              <td style={{ border: "1px solid #ddd", padding: "8px" }}>{device.Location || device.location || "-"}</td>
              <td style={{ border: "1px solid #ddd", padding: "8px" }}>{device.UserId || device.userId || "-"}</td>
            </tr>
          </tbody>
        </table>
      )}

      <button onClick={onBack} style={{ marginTop: "15px", padding: "4px 16px", cursor: "pointer" }}>
        Back
      </button>
    </div>
  );
};

export default GetDeviceById;
