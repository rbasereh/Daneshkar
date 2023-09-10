using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace aspnetcore4
{
    internal class LinqSamples
    {
        public LinqSamples()
        {
            PersonList = new()
            {
                new Person(1, "ali", 30),
                new Person(2, "reza", 20),
                new Person(3, "reza", 30),
                new Person(4, "reza", 50),
                new Person(5, "hasan", 19),
                new Person(6, "hasan", 60),
                new Person(7, "hasan", 70),
            };

            OrderList = new()
            {
                new OrderRequest(1,"Apple",1),
                new OrderRequest(2,"LG",1),
                new OrderRequest(3,"Apple",3),
                new OrderRequest(4,"LG",3),
                new OrderRequest(5,"LG",2),
                new OrderRequest(6,"LG",4),
                new OrderRequest(7,"Apple",5),
            };
        }
        public List<Person> PersonList { get; }
        public List<OrderRequest> OrderList { get; }

        //Linq intro

        internal void Selecting()
        {
            List<string> result = PersonList.Select(e => e.Name).ToList();
            var result2 = PersonList.Select(e => new { e.Name, e.Age }).ToList();
        }
        internal void Ordering()
        {
            List<Person> result = PersonList.OrderBy(e => e.Name)
                        .ThenBy(e => e.Age)
                        .ToList();

            List<Person> result2 = PersonList.OrderByDescending(e => e.Name)
                        .ThenByDescending(e => e.Age)
                        .ToList();
        }
        internal void Filtering()
        {
            List<Person> result = PersonList.Where(e => e.Name == "hasan")
                            .ToList();
        }
        internal void SelectOneElement()
        {
            Person result = PersonList.First(e => e.Name == "hasan"); //OrDefault
            Person result2 = PersonList.Last(e => e.Name == "hasan"); //OrDefault
            Person result3 = PersonList.Single(e => e.Name == "hasan"); //OrDefault
        }
        internal void DistinctSample()
        {
            List<string> result = PersonList.Select(e => e.Name)
                            .Distinct()
                            .ToList();

            var result2 = PersonList.DistinctBy(e => e.Name)
                            .ToList();
        }

        internal void TakeSkipDistinctSample()
        {
            var result = PersonList.Skip(5)
                .ToList();
            var resultSkipLast = PersonList.SkipLast(5)
               .ToList();
            var result2 = PersonList.SkipWhile(e => e.Age < 18)
                .ToList();
            var result3 = PersonList.SkipWhile(e => e.Age < 60)
              .ToList();
            var result31 = PersonList.Where(e => e.Age < 60)
            .ToList();

            var result4 = PersonList.Take(5)
               .ToList();
            var resultTakeLast = PersonList.TakeLast(5)
               .ToList();
            var result5 = PersonList.TakeWhile(e => e.Age < 18)
                .ToList();
            var result6 = PersonList.TakeWhile(e => e.Age < 60)
              .ToList();

            var result61 = PersonList.Where(e => e.Age < 60)
            .ToList();

        }

        internal void ChunkSample()
        {
            List<Person[]> result = PersonList.Chunk(4)
                .ToList();

            foreach (Person[] arr in result)
            {
                foreach (Person person in arr)
                {
                    //Person
                }
            }
            //var s = result[0][1];
            //Person[] arr1 = result[0];
            //Person person1 = arr1[0];
            //var arr2 = result[1];
            //var arr3 = result[2];
        }
        internal void GroupBySample()
        {
            var result = PersonList.GroupBy(e => e.Name)
                // .Select(e => new { name = e.Key, listpersons = e.ToList() })
                .Select(e => new PersonGroup() { GroupName = e.Key, PersonList = e.ToList() })
                .ToList();

            var grouplist = PersonList.GroupBy(e => e.Name);

            foreach (var group in grouplist)
            {

            }

        }
        void ForeachSample()
        {
            foreach (Person person in PersonList)
            {
                SendSms(person);
            }

            PersonList.ForEach(e => SendSms(e));

            PersonList.ForEach(e =>
            {
                SendSms(e);
                //... 
            });
        }

        private void SendSms(Person e)
        {
            //throw new NotImplementedException();
        }

        internal void join()
        {

            var list = OrderList.Select(e => e.PersonId).ToList();

            var list2 = OrderList.Join(
                PersonList,
                order => order.PersonId,
                person => person.Id,
                (order, person) =>
                new
                {
                    order = order,
                    person = person,
                }
               ).ToList();

            var orderPersonNames = list2.Select(e => e.person.Name).Distinct().ToList();

        }

    }
    public class PersonGroup
    {
        public string GroupName { get; set; }
        public List<Person> PersonList { get; set; }
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

    public class OrderRequest
    {

        public OrderRequest(int id, string orderDecription, int personId)
        {
            Id = id;
            OrderDecription = orderDecription;
            PersonId = personId;
        }

        public int Id { get; set; }
        public string OrderDecription { get; set; }
        public int PersonId { get; set; }
    }
}
