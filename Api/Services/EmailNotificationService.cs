using EmployeeLeaveManagement.Api.Interfaces;

namespace EmployeeLeaveManagement.Api.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent : {message}");
        }
    }
}
