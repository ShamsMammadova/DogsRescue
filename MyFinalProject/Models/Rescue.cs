using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class Rescue
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<RescuePhoto> RescuePhotos { get; set; }
    }
}
