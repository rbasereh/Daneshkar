using aspnetcore9.Data;
using aspnetcore9.Models;

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
    }
}
