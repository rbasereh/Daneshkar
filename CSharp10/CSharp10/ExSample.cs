namespace CSharp10
{
    public class CustomException : Exception
    {
        public CustomException(string errorMeesage, string hint) : base(errorMeesage)
        {
            Hint = hint;
        }

        public string Hint { get; set; }
    }
    //Exception Course
    public class ExSample
    {
        public void Run()
        {
            var fileName = "D:\\userInput.txt";

            int x = 0;
            int y = 100;
            Person person = new Person() { Name = "ali", NationalCode = "10" };

            try
            {
                CheckValid(person);

                y = 10 / x;

                ReadFromFile(fileName);
                Console.WriteLine("ReadFromFile");
            }
            catch (CustomException ex) when (ex.Hint != null)
            {
                Console.WriteLine("User Error ....!!!!" + ex.Hint);
            }
            catch (CustomException ex) when (ex.Hint is null)
            {
                Console.WriteLine("User Error ....!!!! not found Hint");
            }
            catch (Exception ex) when 
                        (  ex is DivideByZeroException 
                        || ex is ArgumentOutOfRangeException)
            {
                //......
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Error ....!!!!");
            }
            finally
            {
                Console.Write(y);
            }

        }

        private void CheckValid(Person person)
        {
            if (person.NationalCode.Length < 10)
            {
                throw new CustomException("NationalCode Length Should be 10 Character", "hint 1");
            }
            if (person.Name.Length < 3)
            {
                throw new CustomException("Name Length Should be Greater than 3 Character", "hint 2");
            }
        }

        private string ReadFromFile(string fileName)
        {
            string content = "";
            //if (File.Exists(FileName))
            content = File.ReadAllText(fileName);
            return content;
        }

        private void WriteToFile()
        {
            Console.WriteLine("input : ");

            while (true)
            {

                var str = Console.ReadLine();
                if (str == "0")
                    break;
                File.AppendAllText("userInput.txt", str + Environment.NewLine);
            }
        }
    }
    public class Person
    {
        public string NationalCode { get; set; }
        public string Name { get; set; }
        public PersonRole Role { get; set; } 

    }
    public enum PersonRole
    {
        Manager,
        Employee,
        InventoryUser,
        Salesman
    }


}
