using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;
using Pustok.Models;

namespace Pustok.Areas.Manage.Controllers;
[Area("Manage")]
public class AuthorController(AppDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        var authors = dbContext.Authors
            .Include(a=> a.Books)
            .ToList();
        return View(authors);
    }

    public IActionResult Delete(int id)
    {
        var author = dbContext.Authors.Find(id);
        if (author == null) return NotFound();
        dbContext.Authors.Remove(author);
        dbContext.SaveChanges();
        return Ok();
    }

    public IActionResult Detail(int id)
    {
        var author = dbContext.Authors
            .Include(a => a.Books)
            .FirstOrDefault(a => a.Id == id);
        if (author == null) return NotFound();
        return PartialView("_AuthorDetailPartial", author);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Author author )
    {
        if (!ModelState.IsValid)
            return  View();
        if (dbContext.Authors.Any(a => a.Name.ToLower() == author.Name.ToLower()))
        {
            ModelState.AddModelError("Name", "This author already exists");
            return View();
        }
        dbContext.Authors.Add(author);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Update(int id)
    {
        var author = dbContext.Authors.Find(id);
        if (author == null) return NotFound();
        return View(author);
    }
    [HttpPost]
    public IActionResult Update(Author author)
    {
        if (!ModelState.IsValid)
            return View(author);
        var existAuthor = dbContext.Authors.Find(author.Id);
        if (existAuthor == null) return NotFound();
        if (dbContext.Authors.Any(a => a.Name.ToLower() == author.Name.ToLower() && a.Id != author.Id))
        {
            ModelState.AddModelError("Name", "This author already exists");
            return View(author);
        }
        existAuthor.Name = author.Name;
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
}