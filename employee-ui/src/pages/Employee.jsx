import { useEffect, useState } from "react";
import api from "../services/api";

export default function Employees() {
    const [employees, setEmployees] = useState([]);
    useEffect(() => {
        api.get("/employees", {
            headers: { Authorization: `Bearer ${localStorage.getItem("token")}` }
        }).then(r => setEmployees(r.data));
    }, []);
    return (
        <>
            <h2>Employees</h2>
            {
                employees.map(emp =>
                    <div
                        key={emp.userid}>
                        {emp.username }
                    </div>
                )
            }
        </>
    )
};