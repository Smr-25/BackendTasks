using FirstApiApp.Data;
using FirstApiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiApp.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController(AppDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var categories = dbContext.Categories.ToList();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var category = dbContext.Categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
            return NotFound();

        return Ok(category);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Category category)
    {
        dbContext.Categories.Add(category);
        dbContext.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Category updatedCategory)
    {
        var category = dbContext.Categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
            return NotFound();
        category.Name = updatedCategory.Name;
        category.Description = updatedCategory.Description;
        dbContext.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var category = dbContext.Categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
            return NotFound();
        dbContext.Categories.Remove(category);
        dbContext.SaveChanges();
        return NoContent();
    }
    
    [HttpPost("bulk")]
    public IActionResult PostBulky([FromBody] List<Category> categories)
    {
        dbContext.Categories.AddRange(categories);
        dbContext.SaveChanges();
        return Ok();
    }
}