using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp11
{
    internal class Handler2
    {
        public void Validate()
        {
            Person person = new Person();

            //Func<Person, bool> func;
            //Predicate<Person> predicate;

            List<Predicate<Person>> predicates = new List<Predicate<Person>>
            {
                ValidateTypes.PersonAgeLessThan18,
                ValidateTypes.PersonIsValid,
                ValidateTypes.check1,
                ValidateTypes.check2
            };

            foreach (Predicate<Person> item in predicates)
            {
                bool result = item(person);
                //bool result = item.Invoke(person);

                //if (result == false)
                if (!result)
                {
                    Console.WriteLine("person is Not Valid");
                    break;
                }
            }

            //ValidateTypes.PersonAgeLessThan18(person);
            //ValidateTypes.PersonIsValid(person);
        }

    }

    internal static class ValidateTypes
    {
        public static bool PersonAgeLessThan18(Person person)
        {
            return person.Year < 18;
        }
        public static bool check1(Person person)
        {
            return true;
        }
        public static bool check2(Person person)
        {
            return true;
        }
        public static bool PersonIsValid(Person person)
        {
            return (person.Type == 1 || person.Type == 2)
                && (person.Year < 100 && person.Year > 0);
        }
    }

}
