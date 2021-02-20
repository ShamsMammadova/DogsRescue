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
    public class BlogPageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public BlogPageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
               Blogs=_db.Blogs,
            };
            return View(homeVM);
        }


        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid) return View(blog);

            if (blog.MainPhoto == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(blog);
            }

            if (!blog.MainPhoto.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type is not valid");
                return View(blog);
            }

            if (blog.MainPhoto.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                return View(blog);
            }

            blog.MainImageUrl = await blog.MainPhoto.SaveAsync(_env.WebRootPath, "teams");

            await _db.Blogs.AddAsync(blog);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }


      

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
           Blog blog= await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();

            return View(blog);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
           Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Blog blog)
        {
            if (!ModelState.IsValid) return View(blog);

          Blog blogFromDb = await _db.Blogs.FindAsync(blog.Id);

            if (blog.MainPhoto != null)
            {
                if (!blog.MainPhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type is not valid");
                    return View(blog);
                }

                if (!blog.MainPhoto.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "File size can not be more than 2 mb");
                    return View(blog);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, blogFromDb.MainImageUrl);

                //save new image
                blogFromDb.MainImageUrl = await blog.MainPhoto.SaveAsync(_env.WebRootPath, "blogs");
            }

           blogFromDb.Header = blog.Header;
            blogFromDb.Content = blog.Content;
            blogFromDb.PublishDate = blog.PublishDate;
            blogFromDb.UpdatedDate = blog.UpdatedDate;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
          Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();

            return View(blog);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            Blog blog = await _db.Blogs.FindAsync(id);

            if (blog == null) return NotFound();

            RemoveImage(_env.WebRootPath, blog.MainImageUrl);
            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }





    }
}