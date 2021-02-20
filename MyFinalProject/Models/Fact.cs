using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class Fact
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Icon { get; set; }

        [Required, StringLength(250)]

        public string Head { get; set; }

        [StringLength(350)]

        public string Info { get; set; }
    }
}
