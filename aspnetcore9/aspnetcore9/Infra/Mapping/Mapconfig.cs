using aspnetcore9.Dtos;
using aspnetcore9.Models;
using AutoMapper;

namespace aspnetcore9.Infra.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            //CreateMap<ProductDto, Product>();
        }
    }


    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(e => e.FullName, e => e.MapFrom(s => $"{s.Name} {s.LName}"));
        }
    }
}
