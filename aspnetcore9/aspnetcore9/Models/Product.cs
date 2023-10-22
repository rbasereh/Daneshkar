using System.ComponentModel.DataAnnotations;

namespace aspnetcore9.Models
{
    public class Retail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<ProductReatils> ProductReatils { get; set; }
    }
    public class ProductReatils
    {
        public int Id { get; set; }
        public int ProductId { get; set; } 
        public int RetailId { get; set; }
        public Retail Retail { get; set; }
    }
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //public List<ProductReatils> ProductReatils { get; set; }

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
