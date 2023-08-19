namespace AttributeSample
{
    [CustomAttribute]
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class User
    {
        [CustomAttribute(Error = "کد رایانه اجباری است"  , Name = "کد رایانه")]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CustomAttribute : Attribute
    {
        public string Name { get; set; }
        public string Error { get; set; } 
    }
}