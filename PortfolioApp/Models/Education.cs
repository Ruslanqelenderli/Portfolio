using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Education
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string OrganizationName { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Info { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public DateTime? Startdate { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public DateTime? EndDate { get; set; }
    }
}
