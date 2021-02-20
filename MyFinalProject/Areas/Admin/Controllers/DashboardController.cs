using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.Helpers;
using MyFinalProject.Models;

namespace MyFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UR.AdminRole)]

    public class DashboardController : Controller
    {
        private UserManager<AppUser> userManager;
        public DashboardController(UserManager<AppUser> _userManager)
        {
            userManager = _userManager;

        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Role()
        {
            IList<AppUser> users = await userManager.GetUsersInRoleAsync(UR.UserRole);
            return View(users);
        }
        public async Task<IActionResult> MakeAdmin(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            await userManager.RemoveFromRoleAsync(user, UR.UserRole);
            await userManager.AddToRoleAsync(user, UR.AdminRole);
            return RedirectToAction(nameof(Role));
        }
    }
}