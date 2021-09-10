using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Online_Sales.Models;
using Online_Sales.ViewModels;
using OnlineSalesBusiness.Abstract;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CategoryController : Controller
    {
        private ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IActionResult List()
        {
            var categories = new CategoryListViewModel()
            {
                Categories = categoryService.GetAll()
            };
            return View(categories);
        }


        public IActionResult CreateCategory()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                if (model == null)
                {
                    return NotFound();
                }
                var entity = new Category()
                {
                    Name = model.Name,
                    Url = model.Url,
                    CategoryId = model.CategoryId
                };
                var name = entity.Name;
                categoryService.Create(entity);

                var msg = new AlertModel()
                {
                    Message = name + " added.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("List");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Remove(int? CategoryId)
        {
            if (CategoryId == null)
            {
                return NotFound();
            }
            var entity = categoryService.GetById((int)CategoryId);
            if (entity == null)
            {
                return NotFound();
            }
            var name = entity.Name;
            categoryService.Remove(entity);

            var msg = new AlertModel()
            {
                Message = name + " deleted.",
                AlertType = "danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("List");
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = categoryService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }

            var model = new CategoryModel()
            {
                Id=(int)id,
                Name = entity.Name,
                Url = entity.Url,
                CategoryId = entity.CategoryId,
                Products = categoryService.GetByIdWithProduct((int)id).ProductCategories.Select(x => x.Product).ToList()

            };
            
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(CategoryModel model,int id)
        {
            if (ModelState.IsValid)
            {
                if (model == null)
                {
                    return NotFound();
                }
                var entity = categoryService.GetById(model.CategoryId);
                entity.Name = model.Name;
                entity.Url = model.Url;
                var name = entity.Name;
                categoryService.Update(entity);

                var msg = new AlertModel()
                {
                    Message = name + " updated.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("List");
            }
            model.Products = categoryService.GetByIdWithProduct(id).ProductCategories.Select(x => x.Product).ToList();
            return View(model);
            
        }

        [HttpPost]
        public IActionResult RemoveFromCategory(int CategoryId, int ProductId)
        {
            categoryService.RemoveFromCategory(CategoryId, ProductId);
            return Redirect("update/"+ CategoryId);
        }

    }
}
