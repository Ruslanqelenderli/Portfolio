using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;
using Online_Sales.ViewModels;
using OnlineSalesBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.Controllers
{
    public class HomeController : Controller
    {
        private IProductService productService;
        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var productlistviewmodel = new ProductListViewModel();
            productlistviewmodel.Products= productService.GetAll();
            return View(productlistviewmodel);
        }

        
    }
}
