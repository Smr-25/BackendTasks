using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Data;
using PustokApp.ViewModels;

namespace PustokApp.Controllers;

public class BooksController(
    AppDbContext dbContext
) : Controller
{
    public IActionResult Details(int id)
    {
        var book = dbContext.Books
            .Include(x => x.Author)
            .FirstOrDefault(b => b.Id == id);
        BookVm bookVm = new()
        {
            Book = book,
            RelatedBooks = dbContext.Books
                .Include(x => x.Author)
                .Where(b => b.AuthorId == book.AuthorId && b.Id != book.Id)
                .ToList()
        };
        return View(bookVm);
    }
}