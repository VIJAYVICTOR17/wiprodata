import { useEffect, useState } from "react";
import ControlLogService from "../Services/ControlLogService";

const ControlLogs = ({ onBack }) => {
  const [logs, setLogs] = useState([]);
  const service = ControlLogService();

  useEffect(() => {
    const fetchLogs = async () => {
      try {
        const data = await service.getAllControlLogs();
        setLogs(data);
      } catch (error) {
        console.error("Error fetching control logs:", error);
      }
    };
    fetchLogs();
  }, []);

  return (
    <div style={{ marginTop: "20px", display: "flex", flexDirection: "column", alignItems: "center" }}>
      {/* ✅ Centered Heading */}
      <h2 style={{ color: "#4CAF50", marginBottom: "15px", textAlign: "center" }}>
        Control Logs
      </h2>

      {/* ✅ Table wrapped in a center container */}
      <div style={{ display: "flex", justifyContent: "center", width: "100%" }}>
        <table
          style={{
            borderCollapse: "collapse",
            marginBottom: "15px",
            minWidth: "600px",
            maxWidth: "800px",
          }}
        >
          <thead>
            <tr style={{ backgroundColor: "#f2f2f2" }}>
              <th style={cellStyle}>Log ID</th>
              <th style={cellStyle}>Sensor ID</th>
              <th style={cellStyle}>Action</th>
              <th style={cellStyle}>Action Time</th>
            </tr>   
          </thead>
          <tbody>
            {logs.length > 0 ? (
              logs.map((log) => (
                <tr key={log.logId}>
                  <td style={cellStyle}>{log.logId}</td>
                  <td style={cellStyle}>{log.sensorId}</td>
                  <td style={cellStyle}>{log.action}</td>
                  <td style={cellStyle}>
                    {new Date(log.actionTime).toLocaleString()}
                  </td>
                </tr>
              ))
            ) : (
              <tr>
                <td colSpan="4" style={{ textAlign: "center", padding: "10px" }}>
                  No logs available
                </td>
              </tr>
            )}
          </tbody>
        </table>
      </div>

      
    </div>
  );
};

const cellStyle = {
  border: "1px solid #ddd",
  padding: "8px",
  textAlign: "center",
};

export default ControlLogs;
