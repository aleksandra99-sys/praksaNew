
using Praksa.Exceptions;
using System.Net;

namespace Praksa.Middleware
{
    public class MiddlewareConfiguration 
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<MiddlewareConfiguration> _logger;

        public MiddlewareConfiguration(RequestDelegate next, ILogger<MiddlewareConfiguration> logger)
        {
            _next = next;
            _logger = logger;
        }

            public async Task Invoke(HttpContext context)
            {
                try
                {
                    await _next(context);
                }
                catch (Exception e)
                {
                    var response = context.Response;
                    response.ContentType = "application/json";

                    if (e is BaseException exception)
                    {
                        response.StatusCode = (int)exception.StatusCode;
                        _logger.LogError(e, e.StackTrace);
                        await response.WriteAsync(new ErrorDetails
                        {
                            Message = exception.Message
                        }.ToString());
                    }
                    else
                    {
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        _logger.LogError(e, e.StackTrace);
                        await response.WriteAsync(new ErrorDetails
                        {
                            Message = e.Message
                        }.ToString());
                    }
                }
            }
    }
}
