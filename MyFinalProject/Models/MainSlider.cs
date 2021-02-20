
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class MainSlider
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        public string Text { get; set; }
        public string Info { get; set; }
        public string active { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
