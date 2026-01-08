using AutoMapper;
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
        CreateMap<CategoryUpdateDto, Category>();
        CreateMap<Product, ProductReturnDto>();
        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductUpdateDto, Product>();
    }
}