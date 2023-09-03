namespace LinqSample
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //
            Person person1 = Search("akbar");
            //Person person2 = Search("hasan");



            Console.WriteLine("Hello, World!");
        }
        public static Person Search(string name)
        {
            List<Person> personList = new()
            {
                new Person(1, "ali", 30),
                new Person(2, "reza", 15),
                new Person(3, "reza", 30),
                new Person(6, "hasan", 45),
                new Person(6, "hasan", 60),
                new Person(5, "hasan", 10),
                new Person(4, "reza", 50),
            };

            //Person? result = personList.FirstOrDefault(e => e.Id == 6);
            //Person? result2 = personList.LastOrDefault(e => e.Id == 6);
            //Person? result = personList.Single(e => e.Id == 10);
            Person? result = personList.SingleOrDefault(e => e.Id == 10);
            /*
                                               return 
            First/Last                         1-n  => 1
            FirstOrDefault/LastOrDefault       0-n  => 1
            
            Single                             1 
            SingleOrDefault


            */
            return result;


            //for (int i = 0; i < personList.Count; i++)
            //{
            //    if (personList[i].Name == name)
            //        return personList[i];
            //}
            //Func<Person, bool> isvalidfunc = IsValid;

            //Person? result =
            //     personList
            //     //.Where(IsValid)
            //     .Where(person =>
            //     person.Name == "hasan" &&
            //     person.Age < 30 
            //     || person.Id == 5
            //     ).FirstOrDefault();

            return null;
        }

        public static bool IsValid(Person person)
        {
            return person.Name == "hasan" && person.Age < 30;
        }
    }
    public class Person
    {
        public Person(int id, string name, int age)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}