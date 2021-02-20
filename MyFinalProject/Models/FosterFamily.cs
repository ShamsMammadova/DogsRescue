using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class FosterFamily
    {
        public int Id { get; set; }
        public string Active { get; set; }

        public string Image { get; set; }
        public string Text { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Info { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
