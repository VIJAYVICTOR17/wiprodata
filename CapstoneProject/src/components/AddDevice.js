import { useState } from "react";
import DeviceService from "../Services/DeviceService";

const AddDevice = ({ onBack }) => {
  const deviceService = DeviceService();

  const [device, setDevice] = useState({
    DeviceName: "",
    DeviceType: "",
    Location: "",
    UserId: "",
  });

  const [message, setMessage] = useState("");

  const handleChange = (e) => {
    setDevice({ ...device, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!device.UserId) {
      setMessage("❌ Please enter a valid UserId.");
      return;
    }

    try {
      console.log("Sending device to backend:", device);
      await deviceService.addDevice({
        ...device,
        UserId: Number(device.UserId),
      });
      setMessage("✅ Device added successfully!");
      setDevice({ DeviceName: "", DeviceType: "", Location: "", UserId: "" });
    } catch (err) {
      console.error("Error adding device:", err.response || err);
      setMessage(`❌ Failed to add device: ${err.response?.data || err.message}`);
    }
  };

  return (
    <div style={{ padding: "20px", display: "flex", flexDirection: "column", alignItems: "center" }}>
      <h2>Add Device</h2>

      <form
        onSubmit={handleSubmit}
        style={{ display: "flex", flexDirection: "column", gap: "15px", minWidth: "250px" }}
      >
        <input
          type="text"
          name="DeviceName"
          placeholder="Device Name"
          value={device.DeviceName}
          onChange={handleChange}
          required
          style={{ padding: "6px" }}
        />
        <input
          type="text"
          name="DeviceType"
          placeholder="Device Type"
          value={device.DeviceType}
          onChange={handleChange}
          required
          style={{ padding: "6px" }}
        />
        <input
          type="text"
          name="Location"
          placeholder="Location"
          value={device.Location}
          onChange={handleChange}
          required
          style={{ padding: "6px" }}
        />
        <input
          type="number"
          name="UserId"
          placeholder="UserId"
          value={device.UserId}
          onChange={handleChange}
          required
          style={{ padding: "6px" }}
        />

        <button
          type="submit"
          style={{
            padding: "4px 30px",
            fontWeight: "bold",
            cursor: "pointer",
            borderRadius: "4px",
            border: "none",
            backgroundColor: "#4CAF50",
            color: "#fff",
            alignSelf: "center",
          }}
        >
          Add
        </button>
      </form>

      {message && <p style={{ marginTop: "10px" }}>{message}</p>}

      <button
        onClick={onBack}
        style={{ marginTop: "15px", padding: "2px 16px", cursor: "pointer" }}
      >
        Back
      </button>
    </div>
  );
};

export default AddDevice;
