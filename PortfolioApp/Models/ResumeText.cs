using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class ResumeText
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Text { get; set; }
    }
}
