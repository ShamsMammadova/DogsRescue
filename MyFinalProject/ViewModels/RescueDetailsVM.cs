using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class RescueDetailsVM
    {
        public Rescue Rescue { get; set; }
        public IEnumerable<RescuePhoto> RescuePhotos { get; set; }
    }
}
