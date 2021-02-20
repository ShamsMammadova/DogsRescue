using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class ContactVM
    {
        public IEnumerable<ContactAdress> contactAdresses { get; set; }
    }
}
