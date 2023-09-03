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
                new Person(7, "hasan", 60),
                new Person(5, "hasan", 10),
                new Person(4, "reza", 50),
            };

            //for (int i = 0; i < personList.Count; i++)
            //{
            //    if (personList[i].Name == name)
            //        return personList[i];
            //}

            Person? result =
                 personList
                 .Where(person => 
                            person.Name == name
                            && person.Age < 30
                            && person.Age > 15

                 ).FirstOrDefault();

            Person? result2 =
                personList
                .FirstOrDefault(person => person.Name == name);

            return result;
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