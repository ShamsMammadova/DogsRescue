using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Areas.Admin.ViewModels;
using MyFinalProject.DAL;
using MyFinalProject.Helpers;

namespace MyFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = UR.AdminRole)]
    public class IndexAController : Controller
    {
        private readonly AppDbContext _db;

        public IndexAController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            AllUserVM allUser = new AllUserVM
            {
                appUsers = _db.Users
            };
            return View(allUser);
        }
    }
}