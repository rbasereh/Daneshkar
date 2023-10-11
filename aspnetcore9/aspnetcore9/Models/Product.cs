using System.ComponentModel.DataAnnotations;

namespace aspnetcore9.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [MinLength(3)]
        public decimal Price { get; set; }
    }

    public abstract class DigitalProduct : Product
    {
        public int CpuGen { get; set; }
    }

    public class LaptopProduct : DigitalProduct
    {
        public int HDD { get; set; }
        public int SSD { get; set; }
        //public int BrandId { get; set; } 
        //public Brand Brand { get; set; }

    }
    public class SmartPhoneProduct : DigitalProduct
    {
        public int RAM { get; set; }
    }
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //public class AsusLaptop : LaptopProduct
    //{

    //}
    //public class HPLaptop : LaptopProduct
    //{

    //}
}
