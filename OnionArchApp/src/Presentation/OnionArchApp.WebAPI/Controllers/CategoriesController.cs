using Microsoft.AspNetCore.Mvc;
using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Application.Services.Interfaces;

namespace OnionArchApp.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController(ICategoryService categoryService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await categoryService.GetAllCategoriesAsync();
        return Ok(categories);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CategoryCreateDto categoryCreateDto)
    {
        var response = await categoryService.CreateCategoryAsync(categoryCreateDto);
        return Ok(response);
    }
}