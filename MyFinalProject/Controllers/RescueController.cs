using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinalProject.DAL;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class RescueController : Controller
    {
        private readonly AppDbContext _db;
        public RescueController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            //eager loading
            return View(_db.Rescues.Include(p => p.RescuePhotos).OrderByDescending(p => p.Id).Take(3));
        }
        [HttpPost]
        public IActionResult LoadRescues(int skip)
        {

            return Json(new
            {
                data = _db.Rescues.Include(p => p.RescuePhotos).OrderByDescending(p => p.Id).Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Description,

                    Photo = p.RescuePhotos.Select(pp => pp.Image).FirstOrDefault()
                })
            });

            var model =
                _db.Rescues.Include(p => p.RescuePhotos).OrderByDescending(p => p.Id).Skip(skip).Take(3);
            return PartialView("_RescuesPartial", model);
        }

        //public IActionResult  Details(int id)
        //{
        //    return View();
        //}

        public async Task<IActionResult> Details(int id)
        {
            if (!_db.Rescues.Any(b => b.Id == id))
            {
                return PartialView("ErrorPage");
            }
            RescueDetailsVM rescue = new RescueDetailsVM
            {
                Rescue = await _db.Rescues.FindAsync(id),
                RescuePhotos = _db.RescuePhotos.Where(image => image.RescueId == id)
            };
            //ViewBag.Banner = _db.SectionBanners.Where(b => b.SectionName == "Blog Details").FirstOrDefault().ImageUrl;
            return View(rescue);
        }




    }
}
