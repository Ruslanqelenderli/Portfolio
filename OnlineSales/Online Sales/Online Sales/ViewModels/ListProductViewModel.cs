
using Online_Sales.Models.PageModel;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.ViewModels
{
    public class ListProductViewModel
    {
        public PageModel PageModel { get; set; }
        public List<Product> Products { get; set; }
    }
}
