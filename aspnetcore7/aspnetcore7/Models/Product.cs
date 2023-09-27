using System.ComponentModel.DataAnnotations;

namespace aspnetcore7.Models
{
    public class Product
    {
        [Display(Name = "کد")]
        public int Id { get; set; }
        [Display(Name = "عنوان محصول")]
        public string Name { get; set; }
        [Display(Name = "قیمت محصول")]
        public decimal Price { get; set; }

        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
