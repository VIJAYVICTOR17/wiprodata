import axios from "axios";
import AuthHeader from "./AuthHeader";

const ProtectedService = () => {
  const adminDashBoard = async () => {
    try {
      const response = await axios.get("https://localhost:7071/api/Vehicles", {
        headers: AuthHeader(),
      });
      return response;
    } catch (error) {
      alert(error);
    }
  };

  const getCustomers = async () => {
    try {
      const response = await axios.get("https://localhost:7071/api/Customers", {
        headers: AuthHeader(),
      });
      return response;
    } catch (error) {
      alert(error);
    }
  };

  const AddCustomer = async (customerData) => {
  try {
    const response = await axios.post("https://localhost:7071/api/Customers", 
      customerData,                           
      { headers: AuthHeader() 
    });
    return response;
  } catch (error) {
    alert(error);
  }
};


  return {
    adminDashBoard,
    getCustomers,
    AddCustomer, // ✅ new method added
  };
};

export default ProtectedService;
