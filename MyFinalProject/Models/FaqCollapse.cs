using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Models
{
    public class FaqCollapse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Heading { get; set; }
        public string Collapse { get; set; }
        public string Show { get; set; }
    }
}
