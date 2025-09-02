import { useState } from "react";
import ControlLogService from "../Services/ControlLogService";

const AddControl = ({ onBack }) => {
  const [sensorId, setSensorId] = useState("");
  const [action, setAction] = useState("");
  const [error, setError] = useState("");
  const [success, setSuccess] = useState("");

  const service = ControlLogService();

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError("");
    setSuccess("");

    if (!sensorId || !action) {
      setError("All fields are required.");
      return;
    }

    try {
      await service.addControlLog({ sensorId: parseInt(sensorId), action });
      setSuccess("Control log added successfully!");
      setSensorId("");
      setAction("");
    } catch (err) {
      console.error("Error adding control log:", err);
      setError("Failed to add control log.");
    }
  };

  return (
    <div
      style={{
        marginTop: "20px",
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
      }}
    >
      <h2 style={{ color: "#4CAF50", marginBottom: "20px" }}>Add Control Log</h2>

      <form
        onSubmit={handleSubmit}
        style={{
          display: "flex",
          flexDirection: "column",
          gap: "12px",
          minWidth: "300px",
        }}
      >
        <input
          type="number"
          placeholder="Sensor ID"
          value={sensorId}
          onChange={(e) => setSensorId(e.target.value)}
          style={inputStyle}
        />

        <input
          type="text"
          placeholder="Action"
          value={action}
          onChange={(e) => setAction(e.target.value)}
          style={inputStyle}
        />

        {error && <div style={{ color: "red" }}>{error}</div>}
        {success && <div style={{ color: "green" }}>{success}</div>}

        <div style={{ display: "flex", gap: "10px", justifyContent: "center" }}>
          <button type="submit" style={submitBtnStyle}>
            Add Control
          </button>

          <button type="button" onClick={onBack} style={backBtnStyle}>
            Back
          </button>
        </div>
      </form>
    </div>
  );
};

const inputStyle = {
  padding: "8px 12px",
  borderRadius: "6px",
  border: "1px solid #ccc",
  fontSize: "14px",
};

const submitBtnStyle = {
  padding: "8px 16px",
  borderRadius: "6px",
  border: "none",
  backgroundColor: "#4CAF50",
  color: "#fff",
  cursor: "pointer",
  fontWeight: "bold",
};

const backBtnStyle = {
  padding: "8px 16px",
  borderRadius: "6px",
  border: "none",
  backgroundColor: "#9e9e9e",
  color: "#fff",
  cursor: "pointer",
  fontWeight: "bold",
};

export default AddControl;
