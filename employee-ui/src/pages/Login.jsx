import { useState, useContext } from "react";

import api from "../services/api";

import { AuthContext } from "../context/AuthContext";

import { useNavigate } from "react-router-dom";

export default function Login() {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const { login } = useContext(AuthContext);
    const navigate = useNavigate();
    const handleLogin = async () => {
        const response = await api.post("/auth/login", { email, password });
        login(response.data);
        navigate("/");
    };
    return (
        <>
            <h2>Login</h2>
            <input type="Email" placeholder="Email" onChange={(e) => setEmail(e.target.value)} />
            <br />
            <input type="password" placeholder="Password" onChange={(e) => setPassword(e.target.value)} />
            <br />
            <button onClick={handleLogin}>Login</button>
        </>
    )
}