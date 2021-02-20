using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class AboutVM
    {
        public IEnumerable<Team> teams { get; set; }
        public IEnumerable<FaqCollapse> faqCollapses { get; set; }
        public MainAbout mainAbout { get; set; }
        public AboutInfo aboutInfo { get; set; }


    }
}
