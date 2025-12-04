using MentorApp.Data;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MentorApp.Controllers;

public class HomeController(MentorDbContext mentorDbContext) : Controller
{
    public IActionResult Index()
    {
        var slider = mentorDbContext.Sliders.FirstOrDefault();
        HomeVm homeVm = new HomeVm()
        {
            Slider = slider,
            WhyUss = mentorDbContext.WhyUss.ToList()
            
        };
        return View(homeVm);
        
        
    }
}