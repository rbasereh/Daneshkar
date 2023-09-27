using aspnetcore7.Data;
using aspnetcore7.Models;
using aspnetcore7.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace aspnetcore7.Controllers
{
    public class ProductController : Controller
    {
        private readonly CategoryService categoryService;

        public ProductController(ProductService service, CategoryService categoryService)
        {
            Service = service;
            this.categoryService = categoryService;
        }

        public ProductService Service { get; }

        public async Task<IActionResult> Index()
        {
            var list = await Service.GetListAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var allcategories = await categoryService.GetListAsync();
            ViewData["CategoryId"] = new SelectList(allcategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product Product)
        {
            if (Product.Name.Length < 3)
                ModelState.AddModelError("Name", "عنوان محصول باید بیشتر از 3 حرف باشد");
            if (Product.CategoryId <= 0)
                ModelState.AddModelError("CategoryId", "ثبت دسته بندی درمحصول اجباری است");

            if (ModelState.IsValid)
            {
                await Service.Create(Product);
                RedirectToAction("Index");
            }
            return View(Product);
        }
    }
}
