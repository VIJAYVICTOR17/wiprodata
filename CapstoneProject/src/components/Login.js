import { useState } from "react";
import AuthService from "../Services/AuthService";

const Login = ({ onShowRegister, onLoginSuccess }) => {
  const [loginData, setLoginData] = useState({ username: "", password: "" });
  const [message, setMessage] = useState("");

  const authService = AuthService();

  const handleChange = (e) =>
    setLoginData({ ...loginData, [e.target.name]: e.target.value });

  const handleLogin = async (e) => {
    e.preventDefault();
    try {
      const result = await authService.login(loginData.username, loginData.password);

      // Show popup
      alert(`Welcome ${loginData.username}!`);

      // Show welcome message
      setMessage(`Welcome ${loginData.username}!`);

      // Pass user info up to parent
      onLoginSuccess(result); 
    } catch (error) {
      setMessage("❌ Login failed!");
    }
  };

  return (
    <div style={{ padding: "20px", maxWidth: "400px" }}>
      <h2>Login</h2>
      <form onSubmit={handleLogin}>
        <label>
          Username:
          <input
            type="text"
            name="username"
            value={loginData.username}
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
            value={loginData.password}
            onChange={handleChange}
            required
          />
        </label>
        <br /><br />
        <button type="submit">Login</button>
      </form>

      <p>
        Don't have an account?{" "}
        <span
          style={{ color: "blue", cursor: "pointer" }}
          onClick={onShowRegister}
        >
          Register here
        </span>
      </p>

      {message && <p>{message}</p>}
    </div>
  );
};

export default Login;
