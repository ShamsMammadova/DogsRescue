using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinalProject.DAL;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class DonateController : Controller
    {
        private readonly AppDbContext _db;

        public DonateController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Donates.OrderByDescending(p => p.Id).Take(3));
            
       
        }




        public async Task<IActionResult> Details(int id)
        {
            if (!_db.Donates.Any(b => b.Id == id))
            {
                return PartialView("ErrorPage");
            }
            DonateDetailsVM donate = new DonateDetailsVM
            {
                Donate = await _db.Donates.FindAsync(id)
            };
            return View(donate);
        }

        public IActionResult LoadDonates(int skip)
        {
            var model = _db.Donates.OrderByDescending(m=>m.Id).Skip(skip).Take(3).ToList();
            return PartialView("_DonatePartial", model);
        }
    }
    
}