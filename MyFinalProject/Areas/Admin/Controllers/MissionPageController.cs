using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;
using MyFinalProject.Extensions;
using static MyFinalProject.Utilities.Utilities;

using System.IO;
using Microsoft.AspNetCore.Authorization;
using MyFinalProject.Helpers;

namespace MyFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class MissionPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public MissionPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            MissionVM missionVM = new MissionVM
            {
                missionImage = _db.MissionImages.First(m => m.Id == 1)
            };
            return View(missionVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            MissionImage missionImage = await _db.MissionImages.FindAsync(id);
            if (missionImage == null) return NotFound();

            return View(missionImage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, MissionImage missionImage)
        {
            if (!ModelState.IsValid) return View(missionImage);

           MissionImage missionImageFromDb = await _db.MissionImages.FindAsync(missionImage.Id);

            if (missionImage.Photo != null)
            {
                if (!missionImage.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(missionImage);
                }

                if (!missionImage.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(missionImage);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, missionImageFromDb.Image);

                //save new image
                missionImageFromDb.Image = await missionImage.Photo.SaveAsync(_env.WebRootPath, "missionImages");
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }
}