import { useEffect, useState } from "react";
import NotificationService from "../Services/NotificationService";

const Notification = () => {
  const [notifications, setNotifications] = useState([]);

  useEffect(() => {
    const fetchNotifications = async () => {
      try {
        const data = await NotificationService().getUserNotifications();
        console.log("Backend notifications:", data); // Debug: check backend response

        // Backend already returns camelCase, so set directly
        setNotifications(data);
      } catch (err) {
        console.error("Error fetching notifications:", err);
      }
    };

    fetchNotifications();
  }, []);

  return (
    <div style={{ marginTop: "20px", textAlign: "center" }}>
      <h2>User Notifications</h2>
      {notifications.length === 0 ? (
        <p>No notifications found.</p>
      ) : (
        <div style={{ display: "inline-block", minWidth: "700px", overflowX: "auto" }}>
          <table style={{ width: "100%", borderCollapse: "collapse", marginTop: "10px" }}>
            <thead>
              <tr style={{ backgroundColor: "#f2f2f2" }}>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>NotificationId</th>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>UserId</th>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>DeviceId</th>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>SensorId</th>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>Message</th>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>CreatedAt</th>
                <th style={{ border: "1px solid #ddd", padding: "8px" }}>Status</th>
              </tr>
            </thead>
            <tbody>
              {notifications.map((note) => (
                <tr
                  key={note.notificationId}
                  style={{ backgroundColor: note.isRead ? "#e0e0e0" : "#fff" }}
                >
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>{note.notificationId}</td>
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>{note.userId}</td>
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>{note.deviceId}</td>
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>
                    {note.sensorId || "-"}
                  </td>
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>{note.message}</td>
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>
                    {new Date(note.createdAt).toLocaleString()}
                  </td>
                  <td style={{ border: "1px solid #ddd", padding: "8px" }}>
                    {note.isRead ? "Read" : "Unread"}
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      )}
    </div>
  );
};

export default Notification;
