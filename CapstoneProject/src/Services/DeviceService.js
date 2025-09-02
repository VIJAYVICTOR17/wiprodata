import axios from "axios";
import AuthHeader from "./AuthHeader";

const DeviceService = () => {
  const baseUrl = "https://localhost:7249/api/Devices";

  const getAllDevices = async () => {
    const response = await axios.get(baseUrl, { headers: AuthHeader() });
    return response.data;
  };

  const addDevice = async (device) => {
    console.log("Sending device to backend:", device);
    const response = await axios.post(baseUrl, device, { headers: AuthHeader() });
    return response.data;
  };

  // ✅ Get device by ID
  const getDeviceById = async (deviceId) => {
    const response = await axios.get(`${baseUrl}/${deviceId}`, { headers: AuthHeader() });
    return response.data;
  };

  // ✅ Update device
  const updateDevice = async (deviceId, device) => {
    console.log("Updating device:", device);
    const response = await axios.put(`${baseUrl}/${deviceId}`, device, {
      headers: AuthHeader(),
    });
    return response.data;
  };

  // ✅ Delete device (optional, for future)
  const deleteDevice = async (deviceId) => {
    const response = await axios.delete(`${baseUrl}/${deviceId}`, {
      headers: AuthHeader(),
    });
    return response.data;
  };

  return { getAllDevices, addDevice, getDeviceById, updateDevice, deleteDevice };
};

export default DeviceService;
