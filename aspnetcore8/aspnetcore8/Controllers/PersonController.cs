using aspnetcore8.Models;
using aspnetcore8.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore8.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService service;

        public PersonController(PersonService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var persons = service.GetAllPerson();
            return View(persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            service.CreatePerson(person);
            return RedirectToAction("Index");
        }
    }

}
