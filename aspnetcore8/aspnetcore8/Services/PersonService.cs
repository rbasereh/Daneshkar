using aspnetcore8.Data;
using aspnetcore8.Models;
using Newtonsoft.Json.Bson;

namespace aspnetcore8.Services
{
    public class PersonService
    {
        private readonly AppDbContext dbContext;

        public PersonService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void GenerateData()
        {


            for (int i = 0; i < 100000; i++)
            {
                var student1 = new Student()
                {
                    Name = "Ali" + i,
                    LName = "Saberi"+ i,
                    StudentCode = "Code" + i,
                };
                dbContext.Student.Add(student1);


                var studentTpt = new StudentTpt()
                {
                    Name = "Ali" + i,
                    LName = "Saberi" + i,
                    StudentCode = "Code" + i,
                };

                dbContext.StudentTpt.Add(studentTpt);

                var studentTph = new StudentTPH()
                {
                    Name = "Ali" + i,
                    LName = "Saberi" + i,
                    StudentCode = "Code" + i,
                };

                dbContext.StudentTPH.Add(studentTph);
            }

            dbContext.SaveChanges();


        }
        internal void CreatePerson(Person person)
        {
            var student1 = new StudentTPH()
            {
                Name = "Ali",
                LName = "Saberi",
                StudentCode = "10",
            };

            var teacher = new TeacherTPH()
            {
                Name = "hasan",
                LName = "Amiri",
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

            var StudentTPhList = dbContext.StudentTPH.ToList();
            var TeacherTPhList = dbContext.TeacherTPH.ToList();

            var personList = dbContext.Person.ToList();
            return personList;
        }
    }

}
