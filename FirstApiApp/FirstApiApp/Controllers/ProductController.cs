using FirstApiApp.Data;
using FirstApiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController(AppDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var products = dbContext.Products.ToList();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var product = dbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        dbContext.Products.Add(product);
        dbContext.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Product updatedProduct)
    {
        var existingProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);
        if (existingProduct == null)
            return NotFound();
        if (dbContext.Categories.Any(c => c.Id == existingProduct.CategoryId))
            return BadRequest();
        existingProduct.Name = updatedProduct.Name;
        existingProduct.Description = updatedProduct.Description;
        existingProduct.Price = updatedProduct.Price;
        existingProduct.CategoryId = updatedProduct.CategoryId;
        dbContext.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = dbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();
        dbContext.Products.Remove(product);
        dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPost("bulk")]
    public IActionResult PostBulky([FromBody] List<Product> products)
    {
        dbContext.Products.AddRange(products);
        dbContext.SaveChanges();
        return Ok();
    }
}