using FirstApiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiApp.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private List<Category> categories = new()
    {
        new Category { Id = 1, Name = "Electronics", Description = "Electronic items" },
        new Category { Id = 2, Name = "Books", Description = "Various books" },
        new Category { Id = 3, Name = "Clothing", Description = "Apparel and garments" }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var category = categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
            return NotFound();

        return Ok(category);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Category category)
    {
        category.Id = categories.Max(c => c.Id) + 1;
        categories.Add(category);
        return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Category updatedCategory)
    {
        var category = categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
            return NotFound();
        category.Name = updatedCategory.Name;
        category.Description = updatedCategory.Description;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var category = categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
            return NotFound();
        categories.Remove(category);
        return NoContent();
    }
}