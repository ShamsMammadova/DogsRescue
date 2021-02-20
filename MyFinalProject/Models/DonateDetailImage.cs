using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class DonateDetailImage
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public int DonateId { get; set; }

        public virtual Donate Donate { get; set; }
    }
}
