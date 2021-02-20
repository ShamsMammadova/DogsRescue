using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;

namespace MyFinalProject.Controllers
{
    public class ProductListController : Controller
    {
        private readonly AppDbContext _db;

        public ProductListController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }



    }
}