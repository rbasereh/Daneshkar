using aspnetcore5.Models;

namespace aspnetcore5.Data
{
    public class Database
    {
        public Database()
        {
            PersonList = new();
        }
        public List<Person> PersonList { get; set; }
    }
}
