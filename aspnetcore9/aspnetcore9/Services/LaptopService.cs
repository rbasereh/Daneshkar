using aspnetcore9.Data;
using aspnetcore9.Models;

namespace aspnetcore9.Services
{
    public class LaptopService
    {
        private readonly AppDbContext appDbContext;

        public LaptopService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        internal void CreateProduct(LaptopProduct product)
        {
            appDbContext.LaptopProduct.Add(product);
            appDbContext.SaveChanges();
        }

        internal List<LaptopProduct> GetAll()
        {
            var data = appDbContext.LaptopProduct.ToList();
            return data;
        }
    }
}
