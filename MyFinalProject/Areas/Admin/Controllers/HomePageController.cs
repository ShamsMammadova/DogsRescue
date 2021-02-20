using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.Extensions;
using static MyFinalProject.Extensions.IFormFileExtensions;
using static MyFinalProject.Utilities.Utilities;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public HomePageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }


        public IActionResult Slider()
        {

            return View(_db.MainSliders);

        }


        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MainSlider mainSlider)
        {
            if (!ModelState.IsValid) return View(mainSlider);

            if (mainSlider.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(mainSlider);
            }

            if (!mainSlider.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(mainSlider);
            }

            if (mainSlider.Photo.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(mainSlider);
            }

            mainSlider.Image = await mainSlider.Photo.SaveAsync(_env.WebRootPath, "mainliders");

            await _db.MainSliders.AddAsync(mainSlider);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Slider));

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            MainSlider mainSlider = await _db.MainSliders.FindAsync(id);
            if (mainSlider == null) return NotFound();

            return View(mainSlider);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> DeleteGet(int? id)
        {
            if (id == null) return NotFound();

            MainSlider mainSlider = await _db.MainSliders.FindAsync(id);

            if (mainSlider == null) return NotFound();

            return View(mainSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            MainSlider mainSlider = await _db.MainSliders.FindAsync(id);
            RemoveImage(_env.WebRootPath, mainSlider.Image);

            _db.MainSliders.Remove(mainSlider);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Slider));
        }



        //FACT CRUD

        public IActionResult Fact()
        {
            HomeVM homeVM = new HomeVM
            {
                facts=_db.Facts,
            };
            return View(homeVM);
        }


        public async Task<IActionResult> DetailsFact(int? id)
        {
            if (id == null) return NotFound();
            Fact fact = await _db.Facts.FindAsync(id);
            if (fact == null) return NotFound();

            return View(fact);
        }



        public async Task<IActionResult> EditFact(int? id)
        {
            if (id == null) return NotFound();
           Fact fact = await _db.Facts.FindAsync(id);
            if (fact == null) return NotFound();

            return View(fact);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editfact([Bind(include: "Icon, Head, Info")]Fact fact)
        {
            if (!ModelState.IsValid) return View(fact);

            Fact factFromDb = _db.Facts.First();

            factFromDb.Icon = fact.Icon;
            factFromDb.Head = fact.Head;
            factFromDb.Info = fact.Info;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Fact));
        }


    }
}