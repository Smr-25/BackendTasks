using MentorApp.Data;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers;

public class PricingController(MentorDbContext context) : Controller
{

    public async Task<IActionResult> Index()
    {
        var pricingVm = new PricingVm
        {
            Pricings = context.Pricings.ToList(),
            Services =  context.Services.ToList()
        };
        
        return View(pricingVm);
    }
}