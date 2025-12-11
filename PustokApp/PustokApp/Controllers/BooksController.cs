using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;
using Pustok.ViewModel;

namespace Pustok.Controllers;

public class BooksController(AppDbContext dbContext) : Controller
{
    public IActionResult Details(int id)
    {
        var book = dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.BookImages)
            .Include(x=> x.BookTags)
            .ThenInclude(x => x.Tag)
            .FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound();
        BookVm bookVm = new()
        {
            Book = book,
            RelatedBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(b => b.AuthorId == book.AuthorId && b.Id != book.Id)
                .Take(4)
                .ToList()
        };
        return View(bookVm);
    }
    
    public IActionResult BookModal(int id)
    {
        var book = dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.BookImages)
            .Include(x=> x.BookTags)
            .ThenInclude(x => x.Tag)
            .FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound();
        return PartialView("_BooksModalPartial",book);
    }
}