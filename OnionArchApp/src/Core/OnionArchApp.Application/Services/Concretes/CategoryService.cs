using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Application.Interfaces;
using OnionArchApp.Application.Services.Interfaces;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Services.Concretes;

public class CategoryService(IApplicationDbContext applicationDbContext,IMapper mapper) : ICategoryService
{
    public async Task<List<CategoryReturnDto>> GetAllCategoriesAsync()
    {
        var categories = await applicationDbContext.Categories.ToListAsync();
        var categoryDtos = mapper.Map<List<CategoryReturnDto>>(categories);
        return categoryDtos;
    }

    public async Task CreateCategoryAsync(CategoryCreateDto categoryDto)
    {
        var category = mapper.Map<Category>(categoryDto);
        await applicationDbContext.Categories.AddAsync(category);
        await applicationDbContext.SaveChangesAsync();
    }

    public Task UpdateCategoryAsync(CategoryUpdateDto categoryDto)
    {
        var category = mapper.Map<Category>(categoryDto);
        applicationDbContext.Categories.Update(category);
        return applicationDbContext.SaveChangesAsync();
    }

    public Task DeleteCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

}