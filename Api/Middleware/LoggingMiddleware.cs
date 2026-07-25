namespace EmployeeLeaveManagement.Api.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        public LoggingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context) 
        {
            await _requestDelegate(context);
        }
    }
}
