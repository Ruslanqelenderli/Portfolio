
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioApp.Models
{
    public class About : Base
    {
        [Required(ErrorMessage ="Please add all information.")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string PhotoName { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string  Work { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string City  { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string Country  { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please add correct email.")]
        public string Gmail { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public DateTime? Birthday { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string University { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string AboutHimself { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string HowItStarted { get; set; }
        [Required(ErrorMessage ="Please add all information.")]
        public string RelatedToTheFuture { get; set; }

    }
}
