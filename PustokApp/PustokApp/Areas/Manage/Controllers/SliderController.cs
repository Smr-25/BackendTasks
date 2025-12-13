using Microsoft.AspNetCore.Mvc;
using Pustok.Data;

namespace Pustok.Areas.Manage.Controllers;
[Area("Manage")]
public class SliderController(AppDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        var sliders = dbContext.Sliders.ToList();
        return View(sliders);
    }
}