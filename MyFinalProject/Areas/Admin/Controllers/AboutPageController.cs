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
    public class AboutPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public AboutPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
 

        ///TEAM CRUD

        public IActionResult Team()
        {
            AboutVM aboutVM = new AboutVM
            {
                teams = _db.Teams,
            };
            return View(aboutVM);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            if (!ModelState.IsValid) return View(team);

            if (team.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(team);
            }

            if (!team.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(team);
            }

            if (team.Photo.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(team);
            }

            team.Image = await team.Photo.SaveAsync(_env.WebRootPath, "teams");

            await _db.Teams.AddAsync(team);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Team));

        }



        #region Update with ModifiedState
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Team team)
        //{
        //    if (!ModelState.IsValid) return View(team);

        //    _db.Entry(team).State = EntityState.Modified;
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        #endregion

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Team team = await _db.Teams.FindAsync(id);
            if (team == null) return NotFound();

            return View(team);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Team team = await _db.Teams.FindAsync(id);
            if (team == null) return NotFound();

            return View(team);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Team team)
        {
            if (!ModelState.IsValid) return View(team);

            Team teamFromDb = await _db.Teams.FindAsync(team.Id);

            if (team.Photo != null)
            {
                if (!team.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(team);
                }

                if (!team.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(team);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, teamFromDb.Image);

                //save new image
                teamFromDb.Image = await team.Photo.SaveAsync(_env.WebRootPath, "teams");
            }

            teamFromDb.Name = team.Name;
            teamFromDb.Info = team.Info;
            teamFromDb.Email = team.Email;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Team));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Team team = await _db.Teams.FindAsync(id);
            if (team == null) return NotFound();

            return View(team);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            Team team = await _db.Teams.FindAsync(id);

            if (team == null) return NotFound();

            RemoveImage(_env.WebRootPath, team.Image);
            _db.Teams.Remove(team);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Team));
        }


        //QUESTIONS CRUD

        public IActionResult Question()
        {
            AboutVM aboutVM = new AboutVM
            {
            faqCollapses=_db.FaqCollapses
            };
            return View(aboutVM);
        }

        public IActionResult CreateQuestion()
        {

            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateQuestion(FaqCollapse faqCollapse)
        {
         
            await _db.FaqCollapses.AddAsync(faqCollapse);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Question));

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion([Bind(include: "Title, Desc")]FaqCollapse faqCollapse)
        {
            if (!ModelState.IsValid) return View(faqCollapse);

            FaqCollapse faqCollapseFromDb = _db.FaqCollapses.First();

            faqCollapseFromDb.Title = faqCollapse.Title;
            faqCollapseFromDb.Desc = faqCollapse.Desc;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Question));
        }



    }
}