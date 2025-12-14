using System.ComponentModel.DataAnnotations.Schema;
using Pustok.Models.Common;

namespace Pustok.Models;

public class Slider : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string? ImageUrl { get; set; }
    public string ButtonText { get; set; }
    public string ButtonUrl { get; set; }
    public int Order { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
}