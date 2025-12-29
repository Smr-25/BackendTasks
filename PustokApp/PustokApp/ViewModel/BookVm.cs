using Pustok.Models;

namespace Pustok.ViewModel;

public class BookVm
{
    public Book Book { get; set; }
    public List<Book> RelatedBooks { get; set; }
    
}