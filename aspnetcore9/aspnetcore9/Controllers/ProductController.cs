using aspnetcore9.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore9.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService service;

        public ProductController(ProductService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            //service.updateAllProduct();
            var data = service.GetAll();
            return View(data);
        }
        public IActionResult AllProducts()
        {
            var data = service.GetAllProductForCustomer();
            return View(data);
        }
    }
}
