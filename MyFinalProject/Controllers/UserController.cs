using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Helpers;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class UserController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private RoleManager<IdentityRole> roleManager;
        public UserController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        public async Task RoleSeed()
        {
            //if (!await roleManager.RoleExistsAsync(UR.Roles.Admin.ToString()))
            //    await roleManager.CreateAsync(new IdentityRole(UR.Roles.Admin.ToString()));
            //if (!await roleManager.RoleExistsAsync(UR.Roles.User.ToString()))
            //    await roleManager.CreateAsync(new IdentityRole(UR.Roles.User.ToString()));
        }
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            AppUser appuser = new AppUser
            {
                Name = register.Name,
                Surname = register.Surname,
                Email = register.Email,
                UserName = register.UserName

            };

            IdentityResult identityResult = await userManager.CreateAsync(appuser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await userManager.AddToRoleAsync(appuser, UR.Roles.User.ToString());
            await signInManager.SignInAsync(appuser, true);
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginUser)
        {
            if (!ModelState.IsValid) return View(loginUser);
            AppUser user = await userManager.FindByEmailAsync(loginUser.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginUser);
            }


            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                await signInManager.PasswordSignInAsync(user, loginUser.Password, loginUser.RememberMe, true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginUser);
            }
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }





    }
}