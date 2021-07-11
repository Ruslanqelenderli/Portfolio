using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Project:Base
    {
        [Required(ErrorMessage = "Please add all information.")]
        public string PhotoName { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Info { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public DateTime? CreateDate { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public string Client { get; set; }
        [Required(ErrorMessage = "Please add all information.")]
        public Guid ProjectCategoryId { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }
    }
}
