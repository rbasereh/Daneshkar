namespace CSharp9
{
    public class User
    {
        public Gender Gender { get; set; }
        public string NCode { get; set; }
        public string? Name { get; set; }
        public string? LName { get; set; }
        public int Age { get; set; }
        //public bool Active { get; set; } 
        public UserStatus Status { get; set; } // 0 1 2
    }
}