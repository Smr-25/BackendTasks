using AutoMapper;

namespace FirstApiApp.Profiles;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Dtos.Categories.CategoryCreateDto, Models.Category>();
        CreateMap<Dtos.Categories.CategoryUpdateDto, Models.Category>();
        CreateMap<Models.Category, Dtos.Categories.CategoryReturnDto>();

        // CreateMap<Dtos.Products.ProductCreateDto, Models.Product>();
        // CreateMap<Dtos.Products.ProductUpdateDto, Models.Product>();
        // CreateMap<Models.Product, Dtos.Products.ProductReturnDto>()
        //     .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
        //
        // CreateMap<Models.Category, Dtos.Products.CategoryInProductReturnDto>();
    }
}