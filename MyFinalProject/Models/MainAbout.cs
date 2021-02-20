using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class MainAbout
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string ImageLink { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
