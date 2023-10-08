namespace aspnetcore7.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; } 
        public List<Product>? ProductList { get; set; }
    }
}
