using Microsoft.AspNetCore.Mvc;
using OnionArchApp.Application.Services.Interfaces;

namespace OnionArchApp.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController(ICategoryService categoryService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetCategories()
    {
        var categories = categoryService.GetAllCategoriesAsync();
        return Ok(categories);
    }
}