using aspnetcore9.Data;

namespace aspnetcore9.Services
{
    public class ProductService
    {
        private readonly AppDbContext appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

    }
}
