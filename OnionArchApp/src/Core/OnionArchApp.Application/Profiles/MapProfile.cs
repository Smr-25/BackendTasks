using AutoMapper;
using AutoMapper.Internal;
using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Application.Dtos.Product;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Profiles;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Category, CategoryReturnDto>();
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<CategoryUpdateDto, Category>()
            .ForAllMembers(opts =>
                opts.Condition((src, dest, srcMember) => srcMember != null));
        CreateMap<Product, ProductReturnDto>();
        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductUpdateDto, Product>()
            .ForAllMembers(opt =>
                opt.Condition((src, dest, srcMember, destMember) =>
                    srcMember != null));
    }
}