using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Admin:Base
    {
        [Required(ErrorMessage = "Please add all information.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Gmail { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Password { get; set; }
    }
}
