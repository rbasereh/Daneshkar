using System.ComponentModel.DataAnnotations;

namespace aspnetcore6.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name= "نام")]
        public string Name { get; set; }
        [Display(Name= "نام خانوادگی")]
        public string LName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; } 
        public int Age { get; set; }
        public string NickName { get; set; } 
    }
}
