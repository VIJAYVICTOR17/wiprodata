import { useState, useEffect } from "react";
import DeviceService from "../Services/DeviceService";

const Devices = () => {
  const deviceService = DeviceService();
  const [devices, setDevices] = useState([]);

  const fetchDevices = async () => {
    try {
      const data = await deviceService.getAllDevices();
      console.log("Devices from API:", data);
      setDevices(data);
    } catch (err) {
      console.error("Error fetching devices:", err);
    }
  };

  useEffect(() => {
    fetchDevices();
  }, []);

  return (
    <div
      style={{
        padding: "20px",
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
      }}
    >
      <h2>All Devices</h2>

      {devices.length === 0 ? (
        <p>No devices found.</p>
      ) : (
        <table
          style={{
            borderCollapse: "collapse",
            minWidth: "600px",
            textAlign: "center",
          }}
        >
          <thead>
            <tr>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceId</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceName</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceType</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>Location</th>
            </tr>
          </thead>
          <tbody>
            {devices.map((d) => (
              <tr key={d.deviceId || d.DeviceId}>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{d.deviceId || d.DeviceId}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{d.deviceName || d.DeviceName}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{d.deviceType || d.DeviceType}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{d.location || d.Location}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default Devices;
