using aspnetcore7.Data;
using aspnetcore7.Models;
using aspnetcore7.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore7.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController(CategoryService service, ProductService productService)
        {
            Service = service;
            ProductService = productService;
        }

        public CategoryService Service { get; }
        public ProductService ProductService { get; }

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

        public async Task<IActionResult> Details(int id)
        {
            var category = await Service.GetAsync(id);
            //var productList = await ProductService.GetListAsync();
            //var targetproducts = productList.Where(e => e.CategoryId == id).ToList();
            //category.ProductList = targetproducts;

            return View(category);
        }
    }
}
