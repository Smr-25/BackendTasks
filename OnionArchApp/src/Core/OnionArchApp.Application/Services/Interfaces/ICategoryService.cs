using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Services.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryReturnDto>> GetAllCategoriesAsync();
    Task CreateCategoryAsync(CategoryCreateDto categoryDto);
    Task UpdateCategoryAsync(CategoryUpdateDto categoryDto);
    Task DeleteCategoryAsync(int categoryId);
}