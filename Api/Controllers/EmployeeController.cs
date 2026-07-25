using EmployeeLeaveManagement.Api.Interfaces;
using EmployeeLeaveManagement.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZstdSharp.Unsafe;

namespace EmployeeLeaveManagement.Api.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employee;
        public EmployeeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetEmployees()
        {
           return Ok(await _employee.GetEmployees());
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            await _employee.AddEmployee(employee);
            return Ok();
        }
    }
}
