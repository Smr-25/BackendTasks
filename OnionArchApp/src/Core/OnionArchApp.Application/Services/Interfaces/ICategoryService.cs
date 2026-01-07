using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Domain.Entity;

namespace OnionArchApp.Application.Services.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryReturnDto>> GetAllCategoriesAsync();
    Task CreateCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(int categoryId);
}