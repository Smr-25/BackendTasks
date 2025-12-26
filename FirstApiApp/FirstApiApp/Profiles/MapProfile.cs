using AutoMapper;
using FirstApiApp.Dtos.Categories;
using FirstApiApp.Dtos.Products;
using FirstApiApp.Models;

namespace FirstApiApp.Profiles;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Product, ProductReturnDto>();
        CreateMap<Category, CategoryInProductReturnDto>();
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<Category, CategoryReturnDto>();
        CreateMap<Product, ProductInCategoryDto>();
        CreateMap<CategoryUpdateDto, Category>();
        CreateMap<ProductUpdateDto, Product>();
        CreateMap<ProductCreateDto, Product>();
    }
}