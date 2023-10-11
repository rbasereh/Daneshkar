using aspnetcore9.Models;
using aspnetcore9.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore9.Controllers
{
    public class LaptopController : Controller
    {
        private readonly LaptopService service;

        public LaptopController(LaptopService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            List<LaptopProduct> products = service.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LaptopProduct product)
        {
            if (ModelState.IsValid)
            {
                service.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
