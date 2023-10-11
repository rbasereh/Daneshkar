using aspnetcore9.Data;
using aspnetcore9.Models;
using System;

namespace aspnetcore9.Services
{
    public class ProductService
    {
        protected readonly AppDbContext appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        internal void CreateProduct(Product product)
        {
            appDbContext.Add(product);
            appDbContext.SaveChanges();
        }

        internal List<Product> GetAll()
        {
            return appDbContext.Product.ToList();

            //for TPC 
            //var laptopProducts = appDbContext.LaptopProduct.ToList();
            //var smartPhoneProducts = appDbContext.SmartPhoneProduct.ToList();
            //var products = new List<Product>();
            //products.AddRange(laptopProducts);
            //products.AddRange(smartPhoneProducts);
            //return products;
        }

        internal void updateAllProduct()
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    var x = new SmartPhoneProduct()
            //    {
            //        Name = "SmartPhone" + i.ToString(),
            //        Description = " - ",
            //        Price = 10 * i,
            //        RAM = 5,
            //    };
            //    var x2 = new LaptopProduct()
            //    {
            //        Name = "LaptopProduct" + i.ToString(),
            //        Description = " - ",
            //        Price = 10 * i,
            //        HDD = 10
            //    };
            //    appDbContext.Add(x);
            //    appDbContext.Add(x2);
            //}
            //appDbContext.SaveChanges();

            var products = appDbContext.Product.ToList();
            foreach (var product in products)
            {
                if (product is SmartPhoneProduct)
                {
                    product.Price += 10;
                }
                appDbContext.SaveChanges();
            }
        }
    }
}
