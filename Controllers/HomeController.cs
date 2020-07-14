using EjemploDI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EjemploDI.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly GuidService _guidService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(GuidService guidService, ILogger<HomeController> logger)
        {
            _guidService = guidService;
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            var logMessage = $"Controller:{_guidService.ResultadoGuid}";
            
            _logger.LogInformation(logMessage);
            var messages = new List<string>
            {
                HttpContext.Items["MiddlewareGuid"].ToString(),
                logMessage
            };

            return Ok(messages);
        }
    }
}
