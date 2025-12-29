using System.ComponentModel.DataAnnotations;
using Pustok.Models.Common;

namespace Pustok.Models;

public class Setting 
{
    [Key]
    public string Key { get; set; }
    public string Value { get; set; }
}