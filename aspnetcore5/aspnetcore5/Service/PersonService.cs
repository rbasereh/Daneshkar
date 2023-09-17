using aspnetcore5.Data;
using aspnetcore5.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore5.Service
{
    public class PersonService
    {
        public PersonService(Database database)
        {
            Database = database;
        }

        public Database Database { get; }

        internal void Create(Person person)
        {
            if (person.Name.Length < 3)
                throw new ArgumentException("Lentgh Name");
            ///......
            var id = Database.PersonList.Count + 1;
            person.Id = id;
            Database.PersonList.Add(person);
        }

        internal Person? Find(int? id)
        {
            return Database.PersonList.SingleOrDefault(e => e.Id == id);
        }

        internal List<Person> GetAll()
        {
            return Database.PersonList;
        }
    }
}
