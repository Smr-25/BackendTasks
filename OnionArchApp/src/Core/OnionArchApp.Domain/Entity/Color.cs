using OnionArchApp.Domain.Entity.Common;

namespace OnionArchApp.Domain.Entity;

public class Color : BaseEntity
{
    public string Name { get; set; } = null!;
    public string HexCode { get; set; } = null!;
    public List<ProductColor> ProductColors { get; set; } = [];
}