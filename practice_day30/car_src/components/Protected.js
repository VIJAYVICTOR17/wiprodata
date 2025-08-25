import { useState } from "react";
import ProtectedService from "../services/ProtectedService";

const Protected = () => {
  const [cars, setCars] = useState([]);
  const [customers, setCustomers] = useState([]); // ✅ new state
  const protectedService = ProtectedService();

  const showVehicles = async () => {
    try {
      const response = await protectedService.adminDashBoard();
      setCars(response.data); // ✅ use response.data if Axios
    } catch (error) {
      console.error("Error fetching cars", error);
    }
  };

  const showCustomers = async () => {
    try {
      const response = await protectedService.getCustomers(); // ✅ new API call
      setCustomers(response.data);
    } catch (error) {
      console.error("Error fetching customers", error);
    }
  };

  const AddCustomerComponent = () => {
  const [customers, setCustomers] = useState([]);
  const [formData, setFormData] = useState({
    customerID: "",
    firstName: "",
    lastName: "",
    email: "",
    phoneNumber: ""
  });

   const AddCustomer = async () => {
    try {
      const response = await protectedService.addCustomer(formData);
      alert("Customer added successfully ✅");
      setFormData({ customerID: "", firstName: "", lastName: "", email: "", phoneNumber: "" }); // clear form
      getCustomers(); // refresh customer table
    } catch (error) {
      console.error("Error adding customer", error);
    }
  };


  return (
    <div>
      {/* Vehicles Table */}
      <h2 align="center">Vehicles</h2>
      <table border="3" align="center">
        <thead>
          <tr>
            <th>Vehicle ID</th>
            <th>Make</th>
            <th>Model</th>
            <th>Year</th>
            <th>Daily Rate</th>
            <th>Status</th>
            <th>Passenger Capacity</th>
            <th>Engine Capacity</th>
          </tr>
        </thead>
        <tbody>
          {cars.map((item) => (
            <tr key={item.vehicleId}>
              <td>{item.vehicleID}</td>
              <td>{item.make}</td>
              <td>{item.model}</td>
              <td>{item.year}</td>
              <td>{item.dailyRate}</td>
              <td>{item.status}</td>
              <td>{item.passengerCapacity}</td>
              <td>{item.engineCapacity}</td>
            </tr>
          ))}
        </tbody>
      </table>
      <input type="button" value="Show Vehicles" onClick={showVehicles} /> <br /><br />

      {/* Customers Table */}
      <h2 align="center">Customers</h2>
      <table border="3" align="center">
        <thead>
          <tr>
            <th>Customer ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {customers.map((c) => (
            <tr key={c.customerId}>
              <td>{c.customerID}</td>
              <td>{c.firstName}</td>
              <td>{c.lastName}</td>
              <td>{c.email}</td>
              <td>{c.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
      <input type="button" value="Show Customers" onClick={showCustomers} />

        {/* Add Customers */}
      <h2 align="center">AddCustomer</h2>
      <table border="3" align="center">
        <thead>
          <tr>
            <th>Customer ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {customers.map((c) => (
            <tr key={c.customerId}>
              <td>{c.customerID}</td>
              <td>{c.firstName}</td>
              <td>{c.lastName}</td>
              <td>{c.email}</td>
              <td>{c.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
      <input type="button" value="ADD Customer" onClick={AddCustomer} />


    </div>
  );
};

export default Protected;
