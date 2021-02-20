using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class ContactAdress
    {
        public int Id { get; set; }

        public string Icon { get; set; }

        [Required, StringLength(255)]
        public string Title { get; set; }
        public string Desc { get; set; }
     
    }
}
