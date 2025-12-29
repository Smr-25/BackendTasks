using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers;

public class BasketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}