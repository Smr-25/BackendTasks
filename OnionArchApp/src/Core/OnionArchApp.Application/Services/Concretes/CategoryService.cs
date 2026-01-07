using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Application.Interfaces;
using OnionArchApp.Application.Models;
using OnionArchApp.Application.Services.Interfaces;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Services.Concretes;

public class CategoryService(IApplicationDbContext applicationDbContext, IMapper mapper) : ICategoryService
{
    public async Task<ResponseModel<List<CategoryReturnDto>>> GetAllCategoriesAsync()
    {
        var categories = await applicationDbContext.Categories.ToListAsync();
        var categoryReturnDtos = mapper.Map<List<CategoryReturnDto>>(categories);
        return ResponseModel<List<CategoryReturnDto>>.Success(categoryReturnDtos);
    }

    public async Task<ResponseModel<CategoryReturnDto>> CreateCategoryAsync(CategoryCreateDto categoryDto)
    {
        var category = mapper.Map<Category>(categoryDto);
        applicationDbContext.Categories.AddAsync(category);
        applicationDbContext.SaveChangesAsync();
        var categoryReturnDto = mapper.Map<CategoryReturnDto>(category);
        return ResponseModel<CategoryReturnDto>.Success(categoryReturnDto);
    }

    public async Task UpdateCategoryAsync(int categoryId, CategoryUpdateDto categoryDto)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }
}