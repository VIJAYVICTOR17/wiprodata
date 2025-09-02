import axios from "axios";

const AuthService = () => {

    const login = async (username, password) => {
        try {
            const response = await axios.post("https://localhost:7249/api/Auth/login", { username, password });

            if (response.data.token) {
                //alert("Login token: " + response.data.token);
                localStorage.setItem('token', response.data.token);

                // Save username locally so we can show "Welcome username"
                localStorage.setItem("username", username);

                // Save userId from response (if backend returns it)
                if (response.data.userId) {
                    localStorage.setItem('userId', response.data.userId);
                } else {
                    // fallback if backend doesn't return userId
                    localStorage.setItem('userId', "1");
                }
            }

            return response.data; // RETURN ENTIRE DATA, NOT JUST TOKEN
        } catch (error) {
            console.error("Login failed", error);
            throw error;
        }
    };

    const register = async (username, password) => {
        try {
            const response = await axios.post("https://localhost:7249/api/Auth/register", { username, password });
            alert("Registration Successful!");
            return response.data;
        } catch (error) {
            console.error("Registration failed", error);
            throw error;
        }
    };

    return {
        login,
        register
    };
};

export default AuthService;
