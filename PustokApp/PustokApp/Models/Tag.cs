using System.ComponentModel.DataAnnotations;
using Pustok.Models.Common;

namespace Pustok.Models;

public class Tag : BaseEntity
{
    [Required]
    public string Name { get; set; }
    public List<BookTag> BookTags { get; set; }
}