namespace EmployeeLeaveManagement.Api.Models
{
    public class Employee : User
    {
        public string Department { get; set; }
        public string Designation { get; set; }
    }
}
