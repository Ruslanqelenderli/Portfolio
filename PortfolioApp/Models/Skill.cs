using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Skill:Base
    {
        [Required(ErrorMessage = "Please add all information.")]
        public int Point { get; set; }
    }
}
