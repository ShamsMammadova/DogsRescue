using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class RescuePhoto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int RescueId { get; set; }
        public virtual Rescue Rescue { get; set; }


    }
}
