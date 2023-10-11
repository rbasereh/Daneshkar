using aspnetcore9.Data;
using aspnetcore9.Models;
using Microsoft.EntityFrameworkCore;
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
            //2000
            //#region Code

            //var products = appDbContext.Product.ToList();
            //foreach (var product in products)
            //{
            //    if (product is SmartPhoneProduct)
            //    {
            //        product.Price += 10;
            //    }
            //    appDbContext.SaveChanges();
            //}
            //#endregion

            #region Refactor
            //var products = appDbContext.Product.OfType<SmartPhoneProduct>().ToList();
            //foreach (var product in products)
            //{
            //    product.Price += 10;
            //}
            //appDbContext.SaveChanges();
            #endregion
            //IEnumerable
            //IQueryable
            var products = appDbContext.Product.OfType<SmartPhoneProduct>();

            products = products.Where(e => e.Price > 1000);

            products = products.Where(e => e.RAM != null);

            var result = products.ToList();



            var updateProductTest = appDbContext.LaptopProduct.AsNoTracking().FirstOrDefault();

            updateProductTest.Price++;

            var originalValue = appDbContext.Entry(updateProductTest).OriginalValues;
            var value = originalValue.GetValue<decimal>(nameof(updateProductTest.Price));
         
            var current = appDbContext.Entry(updateProductTest).CurrentValues;
            var currentvalue = current.GetValue<decimal>(nameof(updateProductTest.Price));

            //appDbContext.Update(updateProductTest);
            appDbContext.Attach(updateProductTest);
            var updateProductTestState = appDbContext.Entry(updateProductTest);


            //var newProduct = new SmartPhoneProduct() { Name = "Test", Description = "", CpuGen = 10 };
            //appDbContext.Add(newProduct);
            //var newProductState = appDbContext.Entry(newProduct);

            var deleteProductTest = appDbContext.SmartPhoneProduct.AsNoTracking().FirstOrDefault();
            appDbContext.Remove(deleteProductTest);
            var deleteProductTestState = appDbContext.Entry(deleteProductTest);


            //appDbContext.Entry(product).State
            appDbContext.SaveChanges();
        }
    }
}
