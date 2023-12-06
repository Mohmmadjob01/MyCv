using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCv.Data;
using MyCv.Models;
using MyCv.Models.ViewModels;

namespace MyCv.Controllers
{
    public class AccountController : Controller
    {
        
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> _userManager,
            SignInManager<IdentityUser> _signInManager
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser
                {
                    Email = model.Email,
                    UserName = model.Email
                };

                var result = await userManager.CreateAsync(user, model.Password!);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(err.Code, err.Description);
                }
                return View(model);
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var user = await userManager.GetUserAsync(User);
                var result = await signInManager.PasswordSignInAsync(model.Email!,
                       model.Password!, model.RememberMe, false);
                if (result.Succeeded)
                {
                    /*if (await userManager.IsInRoleAsync(user!, "Admin"))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }*/
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                ModelState.AddModelError("", "Invalid user or password");
                return View(model);
            }
            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Back()
        {
            return RedirectToAction("Index" , "Home");
        }
    }
}
