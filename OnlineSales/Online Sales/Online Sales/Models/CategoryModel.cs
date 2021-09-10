using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Please add Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please add Url.")]

        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}
