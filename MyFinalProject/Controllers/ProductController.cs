using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.ViewModels;

namespace MyFinalProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Shop()
        {

            ShopProductVM shopProductVM = new ShopProductVM
            {
               shopProducts=_db.shopProducts,
            };
            return View(shopProductVM);
        }


        public IActionResult Checkout()
        {
            return View();
        }



    }
}