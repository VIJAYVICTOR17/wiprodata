import { useState } from "react";
import AuthService from "../Services/AuthService";

const Register = ({ onShowLogin }) => {
  const [registerData, setRegisterData] = useState({ username: "", password: "" });
  const [message, setMessage] = useState("");

  const authService = AuthService();

  const handleChange = (e) =>
    setRegisterData({ ...registerData, [e.target.name]: e.target.value });

  const handleRegister = async (e) => {
    e.preventDefault();
    try {
      await authService.register(registerData.username, registerData.password);
      setMessage("✅ Registration successful! You can now login.");
    } catch (error) {
      setMessage("❌ Registration failed!");
    }
  };

  return (
    <div style={{ padding: "20px", maxWidth: "400px" }}>
      <h2>Register</h2>
      <form onSubmit={handleRegister}>
        <label>
          Username:
          <input
            type="text"
            name="username"
            value={registerData.username}
            onChange={handleChange}
            required
          />
        </label>
        <br /><br />
        <label>
          Password:
          <input
            type="password"
            name="password"
            value={registerData.password}
            onChange={handleChange}
            required
          />
        </label>
        <br /><br />
        <button type="submit">Register</button>
      </form>

      <p>
        Already have an account?{" "}
        <span
          style={{ color: "blue", cursor: "pointer" }}
          onClick={onShowLogin}
        >
          Login here
        </span>
      </p>

      {message && <p>{message}</p>}
    </div>
  );
};

export default Register;
