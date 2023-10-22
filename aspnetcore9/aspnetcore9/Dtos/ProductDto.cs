namespace aspnetcore9.Dtos
{

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }

    }
    public class PersonDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }


    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RetailDto> Retails { get; set; }
    }
    public class RetailDto
    {
        public string Name { get; set; }
    }
}
