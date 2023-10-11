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

        internal SmartPhoneProduct? GetProduct(int? id)
        {
            return appDbContext.SmartPhoneProduct.SingleOrDefault(e => e.Id == id);
        }

        internal void UpdateProduct(SmartPhoneProduct product)
        {
            //var oldProduct = appDbContext.SmartPhoneProduct
            //        .SingleOrDefault(e => e.Id == product.Id);

            appDbContext.Update(product);
            appDbContext.SaveChanges();

        }
    }
}
