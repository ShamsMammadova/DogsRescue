using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Areas.Admin.ViewModels
{
    public class AllUserVM
    {
        public IEnumerable<AppUser> appUsers { get; set; }
    }
}
