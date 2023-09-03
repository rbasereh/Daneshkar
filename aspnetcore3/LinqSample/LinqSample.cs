using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal class LinqSample
    {
        public LinqSample()
        {
            PersonList = new()
            {
                new Person(1, "ali", 30),
                new Person(2, "reza", 20),
                new Person(3, "reza", 30),
                new Person(6, "hasan", 45),
                new Person(6, "hasan", 60),
                new Person(8, "hasan", 70),
                new Person(5, "hasan", 19),
                new Person(4, "reza", 50),
            };

        }
        public List<Person> PersonList { get; }

        public void SelectSample()
        {
            var reuslt = PersonList.Where(e => e.Age > 30)//.ToList();
                                .Select(e => e.Id).ToList();
            //.Select(e => new { e.Id, e.Name }).ToList();
        }

        public void AnySample()
        {
            /*
            bool hasChild;
            var reuslt = PersonList.Where(e => e.Age < 5).Count();
            if (reuslt > 0)
                hasChild = true;
            else
                hasChild = false;

            var result2 = PersonList.FirstOrDefault(e => e.Age < 5);
            if (result2 != null)
                hasChild = true;
            else
                hasChild = false;
            */
            bool existAnyPerson = PersonList.Any(e => e.Age < 5);
        }

        public void AllSample()
        {
            bool allPerson = PersonList.All(e => e.Age > 5);
        }
        public void AggregateSample()
        {
            //var OldestPerson = PersonList.OrderByDescending(e => e.Age).First();
            //var OldestPersonAge2 = OldestPerson.Age;
            var OldestPersonAge = PersonList.Max(e => e.Age);

            var MinPersonAge = PersonList.Min(e => e.Age);
            var AveragePersonAge = PersonList.Average(e => e.Age);
        }
        public void SkipSample()
        {
            var result = PersonList.Skip(5).Where(e => e.Age > 10).ToList();
            
            var result2 = PersonList.Where(e=>e.Name == "hasan")
                                .Skip(1).First();
        

            var result4 = PersonList.Where(e => e.Name == "hasan")
                                .Skip(1).Take(2).ToList();
        }

    }
}
