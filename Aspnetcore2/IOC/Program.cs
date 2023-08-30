using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonDataBase dataBase = new();
            PersonService service = new(dataBase);
            Person p = new() { Name = "Ali" };

            service.AddPerson(p);
        }
    }
    public class Person
    {
        public string Name { get; set; }
    }
    public class PersonService
    {
        PersonDataBase dataBase { get; set; }
        public PersonService(PersonDataBase data)
        {
            // dataBase = new PersonDataBase();
            dataBase = data;
        }
        public void AddPerson(Person person)
        {
            if (person == null)
                throw new Exception("Person is null");
            if (person.Name == null)
                throw new Exception("Name is null");

            //PersonDataBase dataBase = new PersonDataBase();
            dataBase.AddPersonToDatabase(person);

            dataBase.ExistPerson(person);

        }
        public void ExistPerson(Person person)
        {
            //PersonDataBase dataBase = new PersonDataBase();
            dataBase.ExistPerson(person);
        }
    }
    //public class PersonDataBase2
    //{
    //    public void AddPersonToDatabase(Person person)
    //    {
    //        File.AppendAllText("database.txt", person.Name);
    //    }
    //}
    public class PersonDataBase
    {
        public static List<string> data = new();
        public void AddPersonToDatabase(Person person)
        {
            data.Add(person.Name);
        }
        public bool ExistPerson(Person person)
        {
            return data.Contains(person.Name);
        }
    }
}