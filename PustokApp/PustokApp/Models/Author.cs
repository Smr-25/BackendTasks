using System.ComponentModel.DataAnnotations;
using Pustok.Models.Common;

namespace Pustok.Models;

public class Author : BaseEntity
{
    [Required, MaxLength(20)]
    public string Name { get; set; }
    public List<Book>? Books { get; set; }
}