﻿using aspnetcore9.Models;
using aspnetcore9.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore9.Controllers
{
    public class SmartphoneController : Controller
    {
        private readonly SmartphoneService service;

        public SmartphoneController(SmartphoneService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            List<SmartPhoneProduct> products = service.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SmartPhoneProduct product)
        {
            if (ModelState.IsValid)
            {
                service.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public IActionResult Edit(int? id) 
        {
            SmartPhoneProduct? product = service.GetProduct(id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id,SmartPhoneProduct product)
        {
            if (ModelState.IsValid)
            { 
                service.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
