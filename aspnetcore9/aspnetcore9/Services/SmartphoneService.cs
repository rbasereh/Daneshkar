using aspnetcore9.Data;
using aspnetcore9.Models;

namespace aspnetcore9.Services
{
    public class SmartphoneService : ProductService
    {

        public SmartphoneService(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        internal List<SmartPhoneProduct> GetAll()
        {
            var data = appDbContext.SmartPhoneProduct.ToList();
            return data;
        }
    }
}
