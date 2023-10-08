namespace aspnetcore8.Models
{
    public class PersonTpt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
    }

    public class StudentTpt : PersonTpt
    {
        public string StudentCode { get; set; }
    }
    public class TeacherTpt : PersonTpt
    {
        public int Age { get; set; }
        public string PropertyX { get; set; }
    }
}
