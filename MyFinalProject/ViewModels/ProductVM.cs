using MyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<Product> products { get; set; }
    }
}
