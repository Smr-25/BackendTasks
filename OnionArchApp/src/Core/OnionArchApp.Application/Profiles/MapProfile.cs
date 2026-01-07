using AutoMapper;
using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Profiles;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Category, CategoryReturnDto>();
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<CategoryUpdateDto, Category>();
    }
}