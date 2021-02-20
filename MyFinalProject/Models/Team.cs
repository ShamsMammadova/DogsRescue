using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string Name { get; set; }


        [StringLength(150)]
        public string Info { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
