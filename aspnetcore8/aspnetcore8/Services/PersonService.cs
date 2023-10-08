using aspnetcore8.Data;
using aspnetcore8.Models;

namespace aspnetcore8.Services
{
    public class PersonService
    {
        private readonly AppDbContext dbContext;

        public PersonService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        internal void CreatePerson(Person person)
        {
            var student1 = new Student()
            {
                LName = person.Name,
                Name = person.Name,
                StudentCode = "10",
            };

            var teacher = new Teacher()
            {
                LName = person.Name,
                Name = person.Name,
                Age = 30,
                PropertyX = "Test"
            };

            dbContext.Add(student1);
            dbContext.Add(teacher);
            dbContext.SaveChanges();
        }

        internal List<Person> GetAllPerson()
        {
            var personList = dbContext.Person.ToList();
            return personList;
        }
    }

}
