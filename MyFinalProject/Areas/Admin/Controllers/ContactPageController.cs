using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public ContactPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }


        public IActionResult Contact()
        {
            ContactVM contactVM = new ContactVM
            {
                contactAdresses = _db.ContactAdresses,
            };
            return View(contactVM);
        }


        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null) return NotFound();
        //    ContactAdresses contactAdress = await _db.ContactAdresses.FindAsync(id);
        //    if (contactAdress == null) return NotFound();

        //    return View(contactAdress);
        //}



        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null) return NotFound();
        //    contactAdress contactAdress = await _db.ContactAdresses.FindAsync(id);
        //    if (contactAdress == null) return NotFound();

        //    return View(contactAdress);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Editfact([Bind(include: "Icon, Title, Desc")]contact contactAdress)
        //{
        //    if (!ModelState.IsValid) return View(contactAdress);

        //    contactAdress contactAdressFromDb = _db.ContactAdresses.First();

        //    contactAdressFromDb.Icon = contactAdress.Icon;
        //    contactAdressFromDb.Title = contactAdress.Tile;
        //    contactAdressFromDb.Info = contactAdress.Desc;
        //    await _db.SaveChangesAsync();

        //    return RedirectToAction(nameof(Contact));
        //}



        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null) return NotFound();
        //    conta contact = await _db.ContactAdresses.FindAsync(id);
        //    if (fosterFamily == null) return NotFound();

        //    return View(fosterFamily);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[ActionName("Delete")]
        //public async Task<IActionResult> DeletePost(int? id)
        //{
        //    if (id == null) return NotFound();

        //    ContactAdress contactAdress= await _db.ContactAdresses.FindAsync(id);

        //    if (contactAdress == null) return NotFound();
        //    _db.FosterFamilies.Remove(contactAdress);
        //    await _db.SaveChangesAsync();

        //    return RedirectToAction(nameof(Contact));
        //}

    }
}