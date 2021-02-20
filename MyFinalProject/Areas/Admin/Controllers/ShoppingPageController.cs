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
    public class ShoppingPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public ShoppingPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Shop()
        {
          ShopProductVM shopProductVM = new ShopProductVM
          {
              shopProducts=_db.shopProducts,
          };
            return View(shopProductVM);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShopProduct shopProduct)
        {
            if (!ModelState.IsValid) return View(shopProduct);

            if (shopProduct.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(shopProduct);
            }

            if (!shopProduct.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(shopProduct);
            }

            if (shopProduct.Photo.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(shopProduct);
            }

            shopProduct.Image = await shopProduct.Photo.SaveAsync(_env.WebRootPath, "shopProducts");

            await _db.shopProducts.AddAsync(shopProduct);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Shop));

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
           ShopProduct shopProduct  = await _db.shopProducts.FindAsync(id);
            if (shopProduct == null) return NotFound();

            return View(shopProduct);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            ShopProduct shopProduct = await _db.shopProducts.FindAsync(id);
            if (shopProduct == null) return NotFound();

            return View(shopProduct);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ShopProduct shopProduct)
        {
            if (!ModelState.IsValid) return View(shopProduct);

            ShopProduct shopProductFromDb = await _db.shopProducts.FindAsync(shopProduct.Id);

            if (shopProduct.Photo != null)
            {
                if (!shopProduct.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(shopProduct);
                }

                if (!shopProduct.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(shopProduct);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, shopProductFromDb.Image);

                //save new image
                shopProductFromDb.Image = await shopProduct.Photo.SaveAsync(_env.WebRootPath, "shopProducts");
            }

            shopProductFromDb.Name = shopProduct.Name;
            shopProductFromDb.Price = shopProduct.Price;
            
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Shop));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
           ShopProduct shopProduct = await _db.shopProducts.FindAsync(id);
            if (shopProduct == null) return NotFound();

            return View(shopProduct);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

             ShopProduct shopProduct= await _db.shopProducts.FindAsync(id);

            if (shopProduct == null) return NotFound();

            RemoveImage(_env.WebRootPath, shopProduct.Image);
            _db.shopProducts.Remove(shopProduct);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Shop));
        }

    }
}