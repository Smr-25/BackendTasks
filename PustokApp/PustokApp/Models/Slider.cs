using System.ComponentModel.DataAnnotations.Schema;
using Pustok.Attributes;
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
    [FileLength(2 * 1024 * 1024)]
    [FileType("image/jpeg", "image/png", "image/gif", "image/webp")]
    public IFormFile? ImageFile { get; set; }
}