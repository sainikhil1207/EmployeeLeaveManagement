import { BrowserRouter, Routes, Route } from "react-router-dom";

import Dashboard from "./pages/Dashboard";

import Login from "./pages/Login";

import Employees from "./pages/Employee";

import ApplyLeave from "./pages/ApplyLeave";

import LeaveHistory from "./pages/LeaveHistory";

import Navbar from "./components/Navbar";

import ProtectedRoute from "./components/ProtectedRoute";

function App() {

    return (
        <BrowserRouter>
            <Navbar />
            <Routes>
            <Route path="/login" element={<Login/>}/>
            <Route path="/" element={<ProtectedRoute><Dashboard/></ProtectedRoute>}/>
            <Route path="/employees" element={<ProtectedRoute><Employees/></ProtectedRoute>}/>
            <Route path="/applyleave" element={<ProtectedRoute><ApplyLeave/></ProtectedRoute>}/>
            <Route path="/leavehistory" element={<ProtectedRoute><LeaveHistory/></ProtectedRoute>}/>
            </Routes>
        </BrowserRouter>

    )
};

export default App;