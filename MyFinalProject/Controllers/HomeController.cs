using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {

            HomeVM home = new HomeVM
            {
            mainSliders=_db.MainSliders,
             facts=_db.Facts,
              ourPartners=_db.OurPartners,
                Blogs = _db.Blogs.OrderByDescending(blog => blog.UpdatedDate).Take(3),
            };

            return View(home);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
