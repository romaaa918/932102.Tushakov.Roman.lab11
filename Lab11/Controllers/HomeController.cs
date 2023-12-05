using Lab11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingModelCalc()
        {
            CalcModel values = new CalcModel();

            return View(values);

        }

        public IActionResult UsingServiceInjectionCalc()
        {
            return View();
        }

        public IActionResult UsingViewBagCalc()
        {
            Random rnd = new Random();

            int value1 = rnd.Next(0, 10), value2 = rnd.Next(0, 10);

            ViewBag.Value1 = value1;
            ViewBag.Value2 = value2;

            return View();
        }

        public IActionResult UsingViewDataCalc()
        {
            Random rnd = new Random();

            int value1 = rnd.Next(0, 10), value2 = rnd.Next(0, 10);

            ViewData["Value1"] = value1;
            ViewData["Value2"] = value2;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}