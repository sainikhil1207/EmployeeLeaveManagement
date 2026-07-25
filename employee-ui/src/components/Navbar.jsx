import { Link } from "react-router-dom";

export default function Navabar() {
    return (
        <>
            <Link to="/">Dashboard</Link>
            {"|"}
            <Link to="/employees">Employees</Link>
            {"|"}
            <Link to="/applyleave">Apply Leave</Link>
            {"|"}
            <Link to="/leavehistory">History</Link>
        </>
    )
}