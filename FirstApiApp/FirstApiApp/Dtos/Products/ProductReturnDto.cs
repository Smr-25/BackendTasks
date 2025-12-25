using FirstApiApp.Models;

namespace FirstApiApp.Dtos.Products;

public class ProductReturnDto
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public string Description { get; set; } 
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public CategoryInProductReturnDto Category { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UptadeDate { get; set; }
}

public class CategoryInProductReturnDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}