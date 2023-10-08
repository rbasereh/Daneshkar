namespace aspnetcore8.Models
{
    public class PersonTPH
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
    }

    public class StudentTPH : PersonTPH
    {
        public string StudentCode { get; set; }
    }
    public class TeacherTPH : PersonTPH
    {
        public int Age { get; set; }
        public string PropertyX { get; set; }
    }
}
