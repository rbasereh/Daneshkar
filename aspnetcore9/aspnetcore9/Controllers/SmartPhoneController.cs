using Microsoft.AspNetCore.Mvc;

namespace aspnetcore9.Controllers
{
    public class SmartPhoneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}
