using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.Contracts;

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
            int y = 0;
            int x = 10 / y;

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
