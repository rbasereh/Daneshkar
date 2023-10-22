using aspnetcore9.Domain.Commands;
using aspnetcore9.Domain.Queries;
using aspnetcore9.Models;
using aspnetcore9.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore9.Controllers
{
    public class LaptopController : Controller
    {
        public IMediator Mediator { get; }

        public LaptopController(IMediator mediator)
        {
            Mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            GetAllProductQuery query = new();
            List<LaptopProduct> products = await Mediator.Send(query);
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LaptopProduct product)
        {
            CreateLaptopCommand command = new() { LaptopProduct = product };

            if (ModelState.IsValid)
            {
                Mediator.Send(command);
                //service.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
