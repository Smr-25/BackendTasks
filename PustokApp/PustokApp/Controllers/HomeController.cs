using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;
using Pustok.ViewModel;

namespace Pustok.Controllers;

public class HomeController(AppDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        HomeVm homeVm = new()
        {
            Sliders = dbContext.Sliders.ToList(),
            FeaturedBooks = dbContext.Books.Where(b => b.IsFeatured).Include(x => x.Author).Include(x=>x.BookImages).ToList(),
            NewBooks = dbContext.Books.Include(x => x.Author).Include(x=>x.BookImages).Where(b => b.IsNew).ToList(),
            DiscountedBooks = dbContext.Books.Include(x => x.Author).Include(x=>x.BookImages).Where(b => b.DiscountPercent > 0).ToList()
        };
        return View(homeVm);
    }
}