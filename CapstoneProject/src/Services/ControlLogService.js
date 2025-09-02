import axios from "axios";
import AuthHeader from "./AuthHeader";

const ControlLogService = () => {
  const baseUrl = "https://localhost:7249/api/ControlLogs";

  // ✅ Get all Control Logs
  const getAllControlLogs = async () => {
    const response = await axios.get(baseUrl, { headers: AuthHeader() });
    return response.data;
  };

  // ✅ Add a new Control Log
  const addControlLog = async (controlLog) => {
    const response = await axios.post(baseUrl, controlLog, { headers: AuthHeader() });
    return response.data;
  };

  return { getAllControlLogs, addControlLog };
};

export default ControlLogService;
