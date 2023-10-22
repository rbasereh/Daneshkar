using aspnetcore9.Data;
using aspnetcore9.Models;
using aspnetcore9.Validations;
using AutoMapper;
using FluentValidation;

namespace aspnetcore9.Services
{
    public class LaptopService : ProductService
    {

        public LaptopService(AppDbContext appDbContext, IMapper mapper, IValidator<Product> validator)
            : base(appDbContext, mapper, validator)
        {
        }

        internal List<LaptopProduct> GetAll()
        {
            var data = appDbContext.LaptopProduct.ToList();
            return data;
        }
    }
}
