using Microsoft.AspNetCore.Mvc;
using OnlineSalesBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"] != null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(categoryService.GetAll());
        }
    }
}
