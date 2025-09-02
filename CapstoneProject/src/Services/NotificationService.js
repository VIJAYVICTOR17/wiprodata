import axios from "axios";
import AuthHeader from "./AuthHeader";

const NotificationService = () => {
  const baseUrl = "https://localhost:7249/api/Notifications";

  // Get all notifications for the logged-in user (or all if backend returns all)
  const getUserNotifications = async () => {
    const response = await axios.get(`${baseUrl}/all`, { headers: AuthHeader() });
    return response.data;
  };

  return { getUserNotifications };
};

export default NotificationService;
