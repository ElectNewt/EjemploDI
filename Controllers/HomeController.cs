﻿using EjemploDI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EjemploDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly GuidService _guidService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(GuidService guidService, ILogger<HomeController> logger)
        {
            _guidService = guidService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var logMessage = $"Controller:{_guidService.ResultadoGuid}";
            _logger.LogInformation(logMessage);
            return Ok();
        }
    }
}
