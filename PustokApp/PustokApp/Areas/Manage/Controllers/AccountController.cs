using Microsoft.AspNetCore.Authorization;
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
        if (await userManager.IsInRoleAsync(user, "Member"))
        {
            ModelState.AddModelError("", "Username or password is incorrect");
            return View(adminLoginVm);
        }
        await signInManager.SignInAsync(user, false);
        
        return RedirectToAction("Index", "Dashboard");
    }
    [Authorize(Roles = "Admin")]
    public  async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Login");
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
//         await userManager.AddToRoleAsync(user, "Admin");
//         return Content("Admin created: ");
//     }
 }