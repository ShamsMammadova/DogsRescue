using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Home DbSet
        public DbSet<MainSlider> MainSliders { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetailImage> BlogDetailImages { get; set; }

        public DbSet<OurPartner> OurPartners { get; set; }

        //About DbSet
        public DbSet<Team> Teams { get; set; }
        public DbSet<FaqCollapse> FaqCollapses { get; set; }
        public DbSet<MainAbout> MainAbouts { get; set; }
        public DbSet<AboutInfo> AboutInfos { get; set; }


        //Mission DbSet
        public DbSet<MissionImage> MissionImages { get; set; }
        public DbSet<OurMission> OurMissions { get; set; }
        public DbSet<OurActivity> OurActivities { get; set; }
        public DbSet<FosterFamily> FosterFamilies { get; set; }

        //Contact DbSet
        public DbSet<ContactAdress> ContactAdresses { get; set; }

        //Dpnate DbSet
        public DbSet<Rescue> Rescues { get; set; }
        public DbSet<RescuePhoto> RescuePhotos { get; set; }

        //Dpnate DbSet
        public DbSet<Donate> Donates { get; set; }
        public DbSet<DonateDetailImage> DonateDetailImages { get; set; }

        //Shopping DbSet
        public DbSet<Product> products { get; set; }
        public DbSet<ShopProduct> shopProducts { get; set; }



    }
}
