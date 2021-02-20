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
    public class ClientPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;


        public ClientPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Client()
        {
            MissionVM missionVM = new MissionVM
            {
                fosterFamilies=_db.FosterFamilies,
            };
            return View(missionVM);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FosterFamily fosterFamily)
        {
            if (!ModelState.IsValid) return View(fosterFamily);

            if (fosterFamily.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(fosterFamily);
            }

            if (!fosterFamily.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(fosterFamily);
            }

            if (fosterFamily.Photo.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(fosterFamily);
            }

            fosterFamily.Image = await fosterFamily.Photo.SaveAsync(_env.WebRootPath, "fosterfamilies");

            await _db.FosterFamilies.AddAsync(fosterFamily);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Client));

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
           FosterFamily fosterFamily = await _db.FosterFamilies.FindAsync(id);
            if (fosterFamily == null) return NotFound();

            return View(fosterFamily);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            FosterFamily fosterFamily = await _db.FosterFamilies.FindAsync(id);
            if (fosterFamily == null) return NotFound();

            return View(fosterFamily);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, FosterFamily fosterFamily)
        {
            if (!ModelState.IsValid) return View(fosterFamily);

            FosterFamily fosterFamilyFromDb = await _db.FosterFamilies.FindAsync(fosterFamily.Id);

            if (fosterFamily.Photo != null)
            {
                if (!fosterFamily.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(fosterFamily);
                }

                if (!fosterFamily.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(fosterFamily);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, fosterFamilyFromDb.Image);

                //save new image
                fosterFamilyFromDb.Image = await fosterFamily.Photo.SaveAsync(_env.WebRootPath, "fosterfamilies");
            }

            fosterFamilyFromDb.Name = fosterFamily.Name;
            fosterFamilyFromDb.Text = fosterFamily.Text;
            fosterFamilyFromDb.Info = fosterFamily.Info;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Client));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            FosterFamily fosterFamily = await _db.FosterFamilies.FindAsync(id);
            if (fosterFamily == null) return NotFound();

            return View(fosterFamily);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            FosterFamily fosterFamily = await _db.FosterFamilies.FindAsync(id);

            if (fosterFamily == null) return NotFound();

            RemoveImage(_env.WebRootPath, fosterFamily.Image);
            _db.FosterFamilies.Remove(fosterFamily);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Client));
        }






    }
}