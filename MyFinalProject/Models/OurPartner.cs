using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class OurPartner
    {
        public int Id { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
