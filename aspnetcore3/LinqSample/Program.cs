namespace LinqSample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinqSample linqSample = new();
            linqSample.SkipSample();
            linqSample.AggregateSample();
            linqSample.SelectSample();
            linqSample.AnySample();
            linqSample.AllSample();

            SearchArrayList();
            SearchPerson("");

            Console.WriteLine("Hello, World!");
        }
        public static Person SearchPerson(string name)
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

            //var result1 = personList.First(); //OrDefault
            //var result2 = personList.Last(); //OrDefault
            //var result3 = personList.Single(); // OrDefault
            //var result4 = personList.OfType<Person>();

            //OrderBy
            //OrderByDescending

            //ThenBy
            //ThenByDescending

            var newPersonList = personList.OrderBy(e => e.Age).ToList();

            List<Person> Persons =
            personList.OrderBy(e => e.Age).ThenByDescending(e => e.Name).ToList();

            List<Person> Persons2 =
                personList.OrderByDescending(e => e.Age).ToList();

            var targetpersonList =
                personList.Where(e => e.Name == "hasan").ToList();


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

        public static void SearchArrayList()
        {
            List<object> list = new()
            {
                new Person(1, "ali", 30),
                "test string",
                10,
                5,
                new Person(2, "reza", 41),
                new Person(3, "hasan", 45),
            };
            var AllPersonInlist2 =
                list.Where(e => e.GetType() == typeof(Person)).ToList();

            //int x = 1;
            //Person x2 = new Person(3, "hasan", 45);

            //Type result = x.GetType();
            //Type result2 = x2.GetType(); 

            List<Person> AllPersonInlist = list.OfType<Person>().ToList();


            List<int> AllInetegerInlist = list.OfType<int>().ToList();

            Person? person = list.OfType<Person>().FirstOrDefault(e => e.Name == "ali");


        }

        public static bool IsValid(Person person)
        {
            return person.Name == "hasan" && person.Age < 30;
        }

        public static bool IsValid2(Person person) 
            => person.Name == "hasan" && person.Age < 30;
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