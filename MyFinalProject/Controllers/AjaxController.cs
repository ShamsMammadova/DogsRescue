using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.DAL;
using MyFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using static MyFinalProject.Extensions.IFormFileExtensions;

namespace MyFinalProject.Controllers
{
    public class AjaxController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public AjaxController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
  
        }

        public IActionResult LoadBlogs(int skip)
        {
            var model = _db.Blogs.OrderByDescending(blog => blog.UpdatedDate).Skip(skip).Take(2);
            return PartialView("_LoadBlogsPartialView", model);
        }

    
        public void DeleteDetailImageBlog(int? id)
        {
            BlogDetailImage detailImage = _db.BlogDetailImages.Where(cd => cd.Id == id).FirstOrDefault();
            //RemovePhoto(_env.WebRootPath, detailImage.ImageUrl);
            _db.BlogDetailImages.Remove(detailImage);
            _db.SaveChanges();
        }


        public void DeleteDetailImageDonate(int? id)
        {
            DonateDetailImage detailImage = _db.DonateDetailImages.Where(cd => cd.Id == id).FirstOrDefault();
            //RemovePhoto(_env.WebRootPath, detailImage.ImageUrl);
            _db.DonateDetailImages.Remove(detailImage);
            _db.SaveChanges();
        }

    }
}