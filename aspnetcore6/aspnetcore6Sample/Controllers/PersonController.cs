using Microsoft.AspNetCore.Mvc;

namespace aspnetcore6Sample.Controllers
{
    public class PersonController : Controller
    {
        public PersonController() { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
