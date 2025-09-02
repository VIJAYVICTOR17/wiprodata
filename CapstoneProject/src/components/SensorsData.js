import { useEffect, useState } from "react";
import SensorsDataService from "../Services/SensorsDataService";

const SensorsData = () => {
  const [sensors, setSensors] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const data = await SensorsDataService().getAllSensorsData();
        setSensors(data);
      } catch (err) {
        console.error("Error fetching sensor data:", err);
      }
    };
    fetchData();
  }, []);

  return (
    <div style={{ marginTop: "20px", textAlign: "center" }}>
      <h2>All Sensors Data</h2>
      <div style={{ display: "inline-block", minWidth: "700px" /* adjust width here */ }}>
        <table style={{ width: "100%", borderCollapse: "collapse", marginTop: "10px" }}>
          <thead>
            <tr style={{ backgroundColor: "#f2f2f2" }}>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>SensorId</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceId</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>SensorType</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>SensorStatus</th>
              <th style={{ border: "1px solid #ddd", padding: "8px" }}>ReadingTime</th>
            </tr>
          </thead>
          <tbody>
            {sensors.map((sensor) => (
              <tr key={sensor.sensorId}>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{sensor.sensorId}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{sensor.deviceId}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{sensor.sensorType}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>{sensor.sensorStatus}</td>
                <td style={{ border: "1px solid #ddd", padding: "8px" }}>
                  {new Date(sensor.readingTime).toLocaleString()}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default SensorsData;
