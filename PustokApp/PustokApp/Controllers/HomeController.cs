using Microsoft.AspNetCore.Mvc;
using PustokApp.Data;
using PustokApp.ViewModels;

namespace PustokApp.Controllers;

public class HomeController(AppDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        HomeVm homeVm = new()
        {
            Sliders = dbContext.Sliders.OrderBy(s => s.Order).ToList()
        };
        return View(homeVm);
    }
}