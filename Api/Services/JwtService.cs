using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeeLeaveManagement.Api.Services
{
    public class JwtService
    {
        public string GenerateToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("MySuperSecretKey12345678910111213");
            var descripter = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]{ new Claim(ClaimTypes.Email, email)}),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(descripter);
            return tokenHandler.WriteToken(token);
        }
    }
}
