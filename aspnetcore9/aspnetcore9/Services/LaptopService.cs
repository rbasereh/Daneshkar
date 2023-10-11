using aspnetcore9.Data;
using aspnetcore9.Models;

namespace aspnetcore9.Services
{
    public class LaptopService : ProductService
    {

        public LaptopService(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        internal List<LaptopProduct> GetAll()
        {
            var data = appDbContext.LaptopProduct.ToList();
            return data;
        }
    }
}
