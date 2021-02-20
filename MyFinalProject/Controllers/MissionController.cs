using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class MissionController : Controller
    {
        private readonly AppDbContext _db;
        public MissionController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            MissionVM mission = new MissionVM
            {
               missionImage=_db.MissionImages.First(m=>m.Id==1),
               ourMission=_db.OurMissions.First(m=>m.id==1),
               ourActivities=_db.OurActivities,
               fosterFamilies=_db.FosterFamilies,
            };
            return View(mission);
        }
    }
}