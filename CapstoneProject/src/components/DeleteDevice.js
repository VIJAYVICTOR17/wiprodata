import { useState } from "react";
import DeviceService from "../Services/DeviceService";

const DeleteDevice = ({ onBack }) => {
  const deviceService = DeviceService();
  const [deviceId, setDeviceId] = useState("");
  const [device, setDevice] = useState(null);
  const [message, setMessage] = useState("");

  // Step 1: Fetch device by ID
  const handleFetch = async (e) => {
    e.preventDefault();
    if (!deviceId) {
      setMessage("❌ Please enter a DeviceId.");
      return;
    }
    try {
      const data = await deviceService.getDeviceById(Number(deviceId));
      if (data) {
        setDevice(data);
        setMessage("");
      } else {
        setDevice(null);
        setMessage("⚠️ Device not found.");
      }
    } catch (err) {
      const errorMsg = err.response?.data
        ? JSON.stringify(err.response.data)
        : err.message;
      setMessage(`❌ Failed to fetch device: ${errorMsg}`);
      setDevice(null);
    }
  };

  // Step 2: Delete device
  const handleDelete = async () => {
    if (!device) {
      setMessage("❌ No device to delete.");
      return;
    }
    try {
      await deviceService.deleteDevice(Number(deviceId));
      setMessage("✅ Device deleted successfully!");
      setDevice(null);
      setDeviceId("");
    } catch (err) {
      const errorMsg = err.response?.data
        ? JSON.stringify(err.response.data)
        : err.message;
      setMessage(`❌ Failed to delete device: ${errorMsg}`);
    }
  };

  return (
    <div style={{ padding: "20px", display: "flex", flexDirection: "column", alignItems: "center" }}>
      <h2>Delete Device by ID</h2>

      {/* Step 1: Enter Device ID */}
      <form onSubmit={handleFetch} style={{ display: "flex", flexDirection: "column", gap: "10px" }}>
        <input
          type="number"
          placeholder="Enter DeviceId"
          value={deviceId}
          onChange={(e) => setDeviceId(e.target.value)}
          required
          style={{ padding: "6px" }}
        />
        <button type="submit" style={{ padding: "4px 20px", cursor: "pointer", color: "blue" }}>
          Fetch Device
        </button>
      </form>

      {message && <p style={{ marginTop: "10px" }}>{message}</p>}

      {/* Step 2: Show device details in table */}
      {device && (
        <div style={{ marginTop: "20px", textAlign: "center" }}>
          <table border="1" cellPadding="8" style={{ borderCollapse: "collapse", width: "100%", maxWidth: "600px" }}>
            <thead style={{ backgroundColor: "#4CAF50", color: "white" }}>
              <tr>
                <th>DeviceId</th>
                <th>DeviceName</th>
                <th>DeviceType</th>
                <th>Location</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>{device.DeviceId || device.deviceId}</td>
                <td>{device.DeviceName || device.deviceName}</td>
                <td>{device.DeviceType || device.deviceType}</td>
                <td>{device.Location || device.location}</td>
              </tr>
            </tbody>
          </table>

          <button
            onClick={handleDelete}
            style={{ marginTop: "15px", padding: "6px 16px", cursor: "pointer", color: "white", backgroundColor: "red", border: "none", borderRadius: "4px" }}
          >
            Delete Device
          </button>
        </div>
      )}

      <button onClick={onBack} style={{ marginTop: "20px", padding: "4px 16px", cursor: "pointer" }}>
        Back
      </button>
    </div>
  );
};

export default DeleteDevice;
