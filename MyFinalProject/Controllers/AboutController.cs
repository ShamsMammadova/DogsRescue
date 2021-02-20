using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        public AboutController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            AboutVM about = new AboutVM
            {
                teams=_db.Teams,
                faqCollapses=_db.FaqCollapses,
                mainAbout=_db.MainAbouts.First(b=>b.Id==1),
                aboutInfo=_db.AboutInfos.First(a=>a.Id==1)

            };
            return View(about);
        }
    }
}