using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Models;
using Pustok.ViewModel.Users;

namespace Pustok.Controllers;

public class AccountController(UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager,
    SignInManager<AppUser> signInManager) : Controller
{
    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Register()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Register(UserRegisterVm userRegisterVm)
    {
        if (!ModelState.IsValid)
        {
            return View(userRegisterVm);
        }
        var user = await userManager.FindByNameAsync(userRegisterVm.Username);
        if (user != null)
        {
            ModelState.AddModelError("", "Username already taken");
            return View(userRegisterVm);
        }
        user = new AppUser()
        {
            FullName = userRegisterVm.FullName,
            UserName = userRegisterVm.Username,
            Email = userRegisterVm.Email
        };
        IdentityResult identityResult = await userManager.CreateAsync(user, userRegisterVm.Password);
        if (!identityResult.Succeeded)
        {
            foreach (var error in identityResult.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(userRegisterVm);
        }
        await userManager.AddToRoleAsync(user, "Member");
        return RedirectToAction("Login");
    }

    // public async Task<IActionResult> CreateRoleAsync()
    // {
    //     await roleManager.CreateAsync(new IdentityRole("Member"));
    //     await roleManager.CreateAsync(new IdentityRole("Admin"));
    //
    //     return Content("Roles Created");
    // }
    [HttpPost]
    public async Task<IActionResult> Login(UserLoginVm userLoginVm)
    {
        if (!ModelState.IsValid)
            return View(userLoginVm);
        var user = await userManager.FindByNameAsync(userLoginVm.UsernameOrEmail);
        if (user == null)
        {
            user = await userManager.FindByEmailAsync(userLoginVm.UsernameOrEmail);
            if (user == null)
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                return View(userLoginVm);
            }
        }

        
        var result = await signInManager.CheckPasswordSignInAsync(user, userLoginVm.Password, false);
        if (result.IsLockedOut)
        {
            ModelState.AddModelError("", "Lockout");
            return View(userLoginVm);
        }
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Username or password is incorrect");
            return View(userLoginVm);
        }
        
        
        // if (!result)
        // {
        //     ModelState.AddModelError("", "Username or password is incorrect");
        //     return View(userLoginVm);
        // }
        if (await userManager.IsInRoleAsync(user, "Admin"))
        {
            ModelState.AddModelError("", "Username or password is incorrect");
            return View(userLoginVm);
        }
        //await signInManager.SignInAsync(user, userLoginVm.RememberMe);
        return RedirectToAction("Index", "Home");
    }
    [Authorize(Roles = "Member")]
    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Profile()
    {
        return View();
    }
}