namespace CSharp6.Models
{
    //internal class BookDefentionCategory
    //{
    //    public Category Category { get; set; } 
    //    public BookDefention BookDefention { get; set; }

    //}
    public class BookDefention
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Name { get; set; }

        public string Condition { get; set; }

        public Author Author { get; set; }
        //public string Author { get; set; }

        public string Description { get; set; }
        public List<Book> Books { get; set; }
        public int Quantity { get; set; }
        List<Category> Categories { get; set; }
    }
}
