using System.Threading.Tasks;
using EjemploDI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace EjemploDI.Middleware
{
    public class EjMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<EjMiddleware> _logger;
        public EjMiddleware(RequestDelegate next, ILogger<EjMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, GuidService guidService)
        {
            var logMessage = $"Middleware: {guidService.ResultadoGuid}";
            _logger.LogInformation(logMessage);
            await _next(context);
        }
    }
}
