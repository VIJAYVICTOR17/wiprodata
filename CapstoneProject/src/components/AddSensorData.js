import { useState } from "react";
import SensorsDataService from "../Services/SensorsDataService";

const AddSensorData = ({ onBack }) => {
  const [deviceId, setDeviceId] = useState("");
  const [sensorType, setSensorType] = useState("");
  const [sensorStatus, setSensorStatus] = useState("");
  const [successMsg, setSuccessMsg] = useState("");
  const [hoverBack, setHoverBack] = useState(false); // hover state

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await SensorsDataService().addSensorData({ deviceId, sensorType, sensorStatus });
      setSuccessMsg("Sensor data added successfully!");
      setDeviceId("");
      setSensorType("");
      setSensorStatus("");
    } catch (err) {
      console.error("Error adding sensor data:", err);
      setSuccessMsg("Error adding sensor data");
    }
  };

  return (
    <div style={{ textAlign: "center" }}>
      <h2>Add Sensor Data</h2>
      {successMsg && (
        <div style={{ color: successMsg.includes("Error") ? "red" : "green", marginBottom: "10px" }}>
          {successMsg}
        </div>
      )}
      <form onSubmit={handleSubmit} style={{ display: "inline-block", textAlign: "left", minWidth: "300px" }}>
        <div style={{ marginBottom: "8px" }}>
          <label style={{ display: "block", marginBottom: "3px" }}>DeviceId:</label>
          <input
            type="number"
            value={deviceId}
            onChange={(e) => setDeviceId(e.target.value)}
            required
            style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "1px solid #ccc" }}
          />
        </div>

        <div style={{ marginBottom: "8px" }}>
          <label style={{ display: "block", marginBottom: "3px" }}>SensorType:</label>
          <input
            type="text"
            value={sensorType}
            onChange={(e) => setSensorType(e.target.value)}
            required
            style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "1px solid #ccc" }}
          />
        </div>

        <div style={{ marginBottom: "8px" }}>
          <label style={{ display: "block", marginBottom: "3px" }}>SensorStatus:</label>
          <input
            type="text"
            value={sensorStatus}
            onChange={(e) => setSensorStatus(e.target.value)}
            required
            style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "1px solid #ccc" }}
          />
        </div>

        <div style={{ display: "flex", justifyContent: "center", gap: "10px", marginTop: "15px" }}>
          <button
            type="submit"
            style={{
              padding: "10px 20px",
              borderRadius: "6px",
              border: "none",
              backgroundColor: "#4CAF50",
              color: "#fff",
              fontWeight: "bold",
              cursor: "pointer",
            }}
          >
            Add
          </button>

          <button
            type="button"
            onClick={onBack}
            onMouseEnter={() => setHoverBack(true)}
            onMouseLeave={() => setHoverBack(false)}
            style={{
              padding: "10px 20px",
              borderRadius: "6px",
              border: "1px solid #ccc",
              backgroundColor: hoverBack ? "#a09c9c42" : "transparent",
              color: "#000",
              cursor: "pointer",
            }}
          >
            Back
          </button>
        </div>
      </form>
    </div>
  );
};

export default AddSensorData;
