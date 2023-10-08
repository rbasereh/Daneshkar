using aspnetcore8.Models;
using aspnetcore8.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspnetcore8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PersonService Service { get; }

        public HomeController(ILogger<HomeController> logger , PersonService service)
        {
            _logger = logger;
            Service = service;
        }

        public IActionResult Index()
        {
            Service.GenerateData();
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