using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspnetcore5.Data;
using aspnetcore5.Models;

namespace aspnetcore5.Controllers
{
    public class PersonController : Controller
    {
        private readonly Database _context;

        public PersonController(Database context)
        {
            _context = context;
        }

        // GET: Person
        public async Task<IActionResult> Index()
        {
            return _context.PersonList != null ?
                        View(_context.PersonList) :
                        Problem("Entity set 'AppDbContext.Person'  is null.");
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
                _context.PersonList.Add(person);
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
           
            var person = _context.PersonList.SingleOrDefault(e => e.Id == id);

            if (person == null)
                return NotFound();

            return View(person);
        }

    }
}
