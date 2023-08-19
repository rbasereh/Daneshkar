using Aspnetcore1.Models;

namespace Aspnetcore1.Data
{
    public static class DataBase
    {
        public static List<Person> Persons { get; set; } = new List<Person>();

        public static List<Person> GetAllPersons()
        {
            if (Persons == null || Persons.Count == 0)
            {
                Persons = new()
                {
                    new Person() { Id = 1, Name = "Ali", LName = "Sadeghi" },
                    new Person() { Id = 2, Name = "Reza", LName = "Sadeghi" },
                    new Person() { Id = 3, Name = "Hasan", LName = "Alipour" }
                };
            }
            return Persons;
        }
    }
}
