using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class ShopProduct
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string DataName { get; set; }

        public string Image { get; set; }

        public string Icon { get; set; }

        public decimal Price { get; set; }


        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
