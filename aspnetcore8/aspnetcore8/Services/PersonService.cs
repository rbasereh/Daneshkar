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
            var student1 = new StudentTpt()
            {
                LName = person.Name,
                Name = person.LName,
                StudentCode = "10",
            };

            var teacher = new TeacherTpt()
            {
                LName = person.Name,
                Name = person.LName,
                Age = 30,
                PropertyX = "Test"
            };

            dbContext.Add(student1);
            dbContext.Add(teacher);
            dbContext.SaveChanges();
        }

        internal List<Person> GetAllPerson()
        {

            var StudentList = dbContext.Student.ToList();

            var StudentTptList = dbContext.StudentTpt.ToList();

            var personList = dbContext.Person.ToList();
            return personList;
        }
    }

}
