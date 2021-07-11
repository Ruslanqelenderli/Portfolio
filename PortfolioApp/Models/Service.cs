using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Service:Base
    {
        [Required(ErrorMessage = "Please add all information.")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Description { get; set; }
    }
}
