using JokesWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Controllers
{
    // Takes care of /Home path
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //dependency injection
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Returns view for /Home
        public IActionResult Index()
        {
            return View();
        }

        // Returns view for /Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Handles errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
