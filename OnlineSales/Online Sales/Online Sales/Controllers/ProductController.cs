using Microsoft.AspNetCore.Mvc;
using Online_Sales.Models.PageModel;
using Online_Sales.ViewModels;
using OnlineSalesBusiness.Abstract;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult List(string category,int page=1)
        {
            int pageSize = 2;
            var pageModel = new PageModel();
            pageModel.TotalItems = productService.GetCountByCategory(category);
            pageModel.CurrentPage = page;
            pageModel.CurrentCategory = category;
            pageModel.ItemsPerPage = pageSize;
            
            var model = new ListProductViewModel()
            {
                PageModel = pageModel,
                Products = productService.GetProductByCategory(category, page, pageSize)
                
            };
            
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Product product = productService.GetProductDetails(id);
            var model = new DetailsViewModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(x => x.Category).ToList()
            };
            return View(model);
        }


        public IActionResult Search(string word)
        {
            var product = new ProductListViewModel()
            {
                Products = productService.SearchByNameAndDescription(word)
            };
            

            return View(product);
        }
    }
}
