using aspnetcore7.Data;
using aspnetcore7.Models;
using aspnetcore7.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore7.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController(CategoryService service)
        {
            Service = service;
        }

        public CategoryService Service { get; }

        public async Task<IActionResult> Index()
        {
            var list = await Service.GetListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (category.Name.Length < 3)
                ModelState.AddModelError("Name", "عنوان دسته بندی باید بیشتر از 3 حرف باشد");
            
            if (ModelState.IsValid)
            {
                await Service.Create(category);
                RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
