using EmployeeLeaveManagement.Api.Models;

namespace EmployeeLeaveManagement.Api.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<int> AddEmployee(Employee employee);
    }
}
