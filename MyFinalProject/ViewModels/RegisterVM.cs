using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class RegisterVM
    {
        [Required, StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public bool TermsCheck { get; set; }


        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Compare(nameof(Password)), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
