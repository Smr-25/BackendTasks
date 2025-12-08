using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;
using Pustok.ViewModel;

namespace Pustok.Controllers;

public class BooksController(AppDbContext dbContext) : Controller
{
    public IActionResult Index(int id)
    {
        var book = dbContext.Books.Include(x => x.Author).Include(x => x.BookImages).FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound();
        BookVm bookVm = new()
        {
            Book = book
        };
        return View(bookVm);
    }
}