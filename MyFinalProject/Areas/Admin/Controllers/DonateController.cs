using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using static MyFinalProject.Extensions.IFormFileExtensions;
using static MyFinalProject.Utilities.Utilities;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MyFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DonateController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;


        public DonateController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        //public IActionResult Donate()
        //{
        //    DonateDetailsVM donateDetailsVM = new DonateDetailsVM
        //    {
        //        Donate = _db.Donates,
        //    };

        //    return View(donateDetailsVM);
        //}

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Donate donate)
        {
            if (!ModelState.IsValid) return View();

            if (donate.MainPhoto == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(donate);
            }

            if (!donate.MainPhoto.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(donate);
            }

            if (donate.MainPhoto.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(donate);
            }

            donate.MainImageUrl = await donate.MainPhoto.SaveAsync(_env.WebRootPath, "donates");

            await _db.Donates.AddAsync(donate);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Donate));

        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
           Donate donate = await _db.Donates.FindAsync(id);
            if (donate == null) return NotFound();

            return View(donate);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Donate donate = await _db.Donates.FindAsync(id);
            if (donate == null) return NotFound();

            return View(donate);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Donate donate)
        {
            if (!ModelState.IsValid) return View(donate);

            Donate donateFromDb = await _db.Donates.FindAsync(donate.Id);

            if (donate.MainPhoto != null)
            {
                if (!donate.MainPhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(donate);
                }

                if (!donate.MainPhoto.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(donate);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, donateFromDb.MainImageUrl);

                //save new image
                donateFromDb.MainImageUrl = await donate.MainPhoto.SaveAsync(_env.WebRootPath, "donates");
            }

            donateFromDb.Name = donate.Name;
            donateFromDb.Info = donate.Info;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Donate));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
         Donate donate = await _db.Donates.FindAsync(id);
            if (donate == null) return NotFound();

            return View(donate);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

           Donate donate = await _db.Donates.FindAsync(id);

            if (donate == null) return NotFound();

            RemoveImage(_env.WebRootPath, donate.MainImageUrl);
            _db.Donates.Remove(donate);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Donate));
        }
    }
}