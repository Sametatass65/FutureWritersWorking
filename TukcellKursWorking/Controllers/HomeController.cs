using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TukcellKursWorking.Models;

namespace TukcellKursWorking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)// her controllerın view'de karşılığı vardır (Klasör)
        {
            _logger = logger;
        }

        public IActionResult Index()// view'de karşılığı var ise action Methoddur.
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}