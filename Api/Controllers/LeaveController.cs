using EmployeeLeaveManagement.Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeLeaveManagement.Api.Controllers
{
    [Route("api/leave")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public LeaveController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpPost("approve")]
        public IActionResult Approve() 
        {
            _notificationService.Send("Leave Approved");
            return Ok("Approved");
        }
    }
}
