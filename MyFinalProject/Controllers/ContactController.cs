using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ContactVM contact = new ContactVM
            {
              contactAdresses=_db.ContactAdresses
            };
            return View(contact);
        }
    }
}