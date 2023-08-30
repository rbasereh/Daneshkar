using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspnetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController()
        {
                
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var x = this.HttpContext.Request;

            var listpersons = GetAllPersons();
            return listpersons;
        }

        private List<Person> GetAllPersons()
        {
            List<Person> persons = new()
            {
                new Person() { Id = 1, Name = "Ali", LName = "Sadeghi" },
                new Person() { Id = 2, Name = "Reza", LName = "Sadeghi" },
                new Person() { Id = 3, Name = "Hasan", LName = "Alipour" }
            };
            return persons;
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
    }
}
