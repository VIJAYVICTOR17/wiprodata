import axios from "axios";
import AuthHeader from "./AuthHeader";

const SensorsDataService = () => {
  const baseUrl = "https://localhost:7249/api/SensorsData";

  // Get all sensor data
  const getAllSensorsData = async () => {
    const response = await axios.get(baseUrl, { headers: AuthHeader() });
    return response.data;
  };

  // Add new sensor data
  const addSensorData = async (sensorData) => {
    const response = await axios.post(baseUrl, sensorData, { headers: AuthHeader() });
    return response.data;
  };

  return { getAllSensorsData, addSensorData };
};

export default SensorsDataService;
