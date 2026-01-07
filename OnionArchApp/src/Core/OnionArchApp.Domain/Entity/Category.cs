using OnionArchApp.Domain.Entity.Common;

namespace OnionArchApp.Domain.Entity;

public class Category : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<Product> Products { get; set; } = [];
}