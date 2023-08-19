using System.ComponentModel.DataAnnotations;

namespace Aspnetcore1.Models
{
    public class Person
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "وارد کردن نام خانوادگی اجباری است")]
        [MinLength(3)]
        [MaxLength(10)]
        public string? Name { get; set; }

        public string? LName { get; set; }
    }
}
