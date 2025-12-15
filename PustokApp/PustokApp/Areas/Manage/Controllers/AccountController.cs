using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Areas.Manage.ViewModels;
using Pustok.Models;

namespace Pustok.Areas.Manage.Controllers;

[Area("Manage")]
public class AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager) : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(AdminLoginVm adminLoginVm)
    {
        if (!ModelState.IsValid)
            return View(adminLoginVm);
        AppUser user = await userManager.FindByNameAsync(adminLoginVm.Username);
        if (user == null)
        {
            ModelState.AddModelError("", "Username or password is incorrect");
            return View(adminLoginVm);
        }
        var result = await userManager.CheckPasswordAsync(user, adminLoginVm.Password);
        if (!result)
        {
            ModelState.AddModelError("", "Username or password is incorrect");
            return View(adminLoginVm);
        }
        await signInManager.SignInAsync(user, false);
        
        return RedirectToAction("Index", "Dashboard");
    }

//     public async Task<IActionResult> CreateAdmin()
//     {
//         AppUser user = new()
//         {
//             UserName = "_admin",
//             FullName = "System Admin",
//             Email = "admin@gmail.com"
//         };
//         var result = await userManager.CreateAsync(user, "_Admin123");
//         if (!result.Succeeded)
//             return Json(result.Errors);
//         
//         return Content("Admin created: ");
//     }
 }