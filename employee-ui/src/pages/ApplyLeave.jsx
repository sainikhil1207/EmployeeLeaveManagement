import { useState } from "react";

export default function ApplyLeave() {
    const [reason, setReason] = useState("");
    const submit = () => {
        alert("Leave applied");
    };
    return (
        <>
            <h2>Apply Leave</h2>
            <input placeholder="Reason" onChange={(e) => setReason(e.target.value)} />
            <button onClick={submit}>Submit</button>
        </>
    )
}