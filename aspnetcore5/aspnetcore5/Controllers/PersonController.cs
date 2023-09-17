using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspnetcore5.Data;
using aspnetcore5.Models;
using aspnetcore5.Service;

namespace aspnetcore5.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService _service;

        public PersonController(PersonService service)
        {
            _service = service;
        }

        // GET: Person
        public async Task<IActionResult> Index()
        {
            var persons = _service.GetAll();
            return View(persons);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _service.Create(person);
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var person = _service.Find(id);

            if (person == null)
                return NotFound();

            return View(person);
        }

    }
}
