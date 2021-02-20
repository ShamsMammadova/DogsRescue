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
    public class PartnerPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public PartnerPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Partner()
        {
            HomeVM homeVM = new HomeVM
            {
                ourPartners = _db.OurPartners,
            };
            return View(homeVM);
        }


        public IActionResult Create()
        {

            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OurPartner ourPartner)
        {
            if (!ModelState.IsValid) return View();

            if (ourPartner.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(ourPartner);
            }

            if (!ourPartner.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(ourPartner);
            }

            if (ourPartner.Photo.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(ourPartner);
            }

            ourPartner.Image = await ourPartner.Photo.SaveAsync(_env.WebRootPath, "partners");

            await _db.OurPartners.AddAsync(ourPartner);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Partner));

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            OurPartner ourPartner = await _db.OurPartners.FindAsync(id);
            if (ourPartner == null) return NotFound();

            return View(ourPartner);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, OurPartner ourPartner)
        {
            if (!ModelState.IsValid) return View(ourPartner);

            OurPartner ourPartnerFromDb = await _db.OurPartners.FindAsync(ourPartner.Id);

            if (ourPartner.Photo != null)
            {
                if (!ourPartner.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(ourPartner);
                }

                if (!ourPartner.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(ourPartner);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, ourPartnerFromDb.Image);

                //save new image
                ourPartnerFromDb.Image = await ourPartner.Photo.SaveAsync(_env.WebRootPath, "ourPartners");
            }


            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Partner));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            OurPartner ourPartner = await _db.OurPartners.FindAsync(id);
            if (ourPartner == null) return NotFound();

            return View(ourPartner);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            OurPartner ourPartner = await _db.OurPartners.FindAsync(id);

            if (ourPartner == null) return NotFound();

            RemoveImage(_env.WebRootPath, ourPartner.Image);
            _db.OurPartners.Remove(ourPartner);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Partner));
        }

    }
}