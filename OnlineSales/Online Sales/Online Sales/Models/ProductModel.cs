using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.Models
{
    public class ProductModel
    {
        
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Please add Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please add Price.")]

        public double? Price { get; set; }
        [Required(ErrorMessage = "Please add Description.")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Please add Image.")]

        public string ImageUrl { get; set; }
        public List<Category> Categories { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
