using NuGet.Protocol.Core.Types;

namespace aspnetcore8.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        //public City City { get; set; }
        //public int CityId { get; set; } 

    }

    public class Student : Person
    {
        public string StudentCode { get; set; }
    }

    public class Teacher : Person
    {
        public int Age { get; set; }
        public string PropertyX { get; set; }
    }

    //IS A
    //has A
}
