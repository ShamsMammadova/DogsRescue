using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{

        public class AppUser:IdentityUser
    {
            [Required, StringLength(100, MinimumLength = 3)]
            public string Name { get; set; }

            [StringLength(100)]
            public string Surname { get; set; }
            public bool IsBlocked { get; set; }

        }
    
}
