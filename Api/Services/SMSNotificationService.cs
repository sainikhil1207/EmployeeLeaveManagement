using EmployeeLeaveManagement.Api.Interfaces;

namespace EmployeeLeaveManagement.Api.Services
{
    public class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Send: {message}");
        }
    }
}
