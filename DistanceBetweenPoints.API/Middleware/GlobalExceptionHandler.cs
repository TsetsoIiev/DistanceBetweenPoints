using DistanceBetweenPoints.Services;

namespace DistanceBetweenPoints.API.Middleware
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public GlobalExceptionHandler(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            if (ex is ArgumentException argEx)
            {
                _logger.LogError(0, argEx, argEx.Message);
            }
            else if (ex is InvalidOperationException ioEx)
            {
                _logger.LogError(0, ioEx, Constants.InvalidOperationExceptionMessage);
            }
            else
            {
                _logger.LogError(0, ex, Constants.UnhandledExceptionMessage);
            }
        }
    }
}
