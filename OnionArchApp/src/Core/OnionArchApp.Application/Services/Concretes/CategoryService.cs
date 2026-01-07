using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Application.Interfaces;
using OnionArchApp.Application.Services.Interfaces;
using OnionArchApp.Domain.Entity;

namespace OnionArchApp.Application.Services.Concretes;

public class CategoryService(IApplicationDbContext applicationDbContext) : ICategoryService
{
    public Task<List<CategoryReturnDto>> GetAllCategoriesAsync()
    {
        var categories = applicationDbContext.Categories
            .Select(c => new CategoryReturnDto(c.Id, c.Name))
            .ToList();
        return Task.FromResult(categories);
    }

    public Task CreateCategoryAsync(Category categoryDto)
    {
        var category = new Category
        {
            Name = categoryDto.Name
        };
        applicationDbContext.Categories.Add(category);
        applicationDbContext.SaveChangesAsync();
        return Task.CompletedTask;
    }

    public Task UpdateCategoryAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }
}