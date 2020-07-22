using KissLog;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Controllers
{
    public class LoggingController : Controller
    {
        private readonly ILogger _logger;
        public LoggingController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.Info("Logando uma informação!");
            return View();
        }
    }
}
