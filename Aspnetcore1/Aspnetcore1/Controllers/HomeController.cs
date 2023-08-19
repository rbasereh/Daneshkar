using Aspnetcore1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aspnetcore1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult FirstView()
        {
            return View();  
        }
    }
}