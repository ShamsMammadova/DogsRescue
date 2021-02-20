using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.Models;
using MyFinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MyFinalProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;

        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            ViewBag.BlogTotalCunt = _db.Blogs.Count();
            //how many pages will display every page will display 2 blogs
            double PageCount = _db.Blogs.Count() / 2F;
            //find page count is whole number?
            int RightSideDouble = (int)((PageCount - (int)PageCount) * 10);
            //if page count is not whole number i add 1 more pagination for display all blogs
            if (RightSideDouble > 0)
            {
                PageCount = PageCount + 0.5;
            }
            ViewBag.PageCount = PageCount; 
            //ViewBag.Banner = _db.SectionBanners.Where(b => b.SectionName == "Blogs").FirstOrDefault().ImageUrl;
            return View(_db.Blogs.OrderByDescending(blog => blog.UpdatedDate).Take(2).ToList());
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!_db.Blogs.Any(b => b.Id == id))
            {
                return PartialView("ErrorPage");
            }
            BlogDetailsVM blog = new BlogDetailsVM
            {
                Blog = await _db.Blogs.FindAsync(id),
                BlogDetailImages = _db.BlogDetailImages.Where(image => image.BlogId == id)
            };
            //ViewBag.Banner = _db.SectionBanners.Where(b => b.SectionName == "Blog Details").FirstOrDefault().ImageUrl;
            return View(blog);
        }
    }
}