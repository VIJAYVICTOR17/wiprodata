import { useState } from "react";
import DeviceService from "../Services/DeviceService";

const UpdateDeviceById = ({ onBack }) => {
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

  const handleUpdate = async (e) => {
    e.preventDefault();
    if (!device) {
      setMessage("❌ No device data to update.");
      return;
    }
    try {
      const updated = await deviceService.updateDevice(Number(deviceId), device);
      setMessage("✅ Device updated successfully!");
      setDevice(updated);
    } catch (err) {
      const errorMsg = err.response?.data
        ? JSON.stringify(err.response.data)
        : err.message;
      setMessage(`❌ Failed to update device: ${errorMsg}`);
    }
  };

  return (
    <div style={{ padding: "20px", display: "flex", flexDirection: "column", alignItems: "center" }}>
      <h2>Update Device by ID</h2>

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

      {/* Step 2: Update Form */}
      {device && (
        <form
          onSubmit={handleUpdate}
          style={{
            marginTop: "20px",
            display: "flex",
            flexDirection: "column",
            gap: "10px",
            width: "300px",
          }}
        >
          <input
            type="text"
            placeholder="Device Name"
            value={device.DeviceName || device.deviceName || ""}
            onChange={(e) => setDevice({ ...device, DeviceName: e.target.value })}
            required
            style={{ padding: "6px" }}
          />
          <input
            type="text"
            placeholder="Device Type"
            value={device.DeviceType || device.deviceType || ""}
            onChange={(e) => setDevice({ ...device, DeviceType: e.target.value })}
            required
            style={{ padding: "6px" }}
          />
          <input
            type="text"
            placeholder="Location"
            value={device.Location || device.location || ""}
            onChange={(e) => setDevice({ ...device, Location: e.target.value })}
            required
            style={{ padding: "6px" }}
          />
          <button type="submit" style={{ marginTop: "12px", padding: "6px 6px", cursor: "pointer", color: "white", border: "none", borderRadius: "4px", backgroundColor: "#4CAF50" }}>
            Update Device
          </button>
        </form>
      )}

      <button onClick={onBack} style={{ marginTop: "15px", padding: "4px 16px", cursor: "pointer" }}>
        Back
      </button>
    </div>
  );
};

export default UpdateDeviceById;
