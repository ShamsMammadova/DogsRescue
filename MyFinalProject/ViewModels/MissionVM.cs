using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class MissionVM
    {
        public MissionImage missionImage { get; set; }
        public OurMission ourMission { get; set; }
        public IEnumerable<OurActivity> ourActivities { get; set; }
        public IEnumerable<FosterFamily> fosterFamilies { get; set; }

    }
}
