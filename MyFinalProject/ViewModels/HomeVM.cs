using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Fact> facts { get; set; }
        public IEnumerable<OurPartner> ourPartners { get; set; }
        public IEnumerable<MainSlider> mainSliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }

    }
}
