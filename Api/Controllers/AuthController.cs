using EmployeeLeaveManagement.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeLeaveManagement.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwt;
        public AuthController(JwtService jwt)
        {
            _jwt = jwt;
        }
        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            if(request.Email == "sainikhil1207@gmail.com" && request.Password == "Admin@123")
            {
                var token = _jwt.GenerateToken(request.Email);
                return Ok(token);
            }
            return Unauthorized();
        }
    }
}
