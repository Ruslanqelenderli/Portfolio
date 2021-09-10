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
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Online_Sales.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private IProductService productService;
        public AdminController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult GetAll()
        {
            var products = new ProductListViewModel()
            {
                Products = productService.GetAll()
            };
            return View(products);
        }



        public IActionResult CreateProduct()
        {
            var categories = productService.GetAllCategory();
            var model = new ProductModel()
            {
                Categories = categories
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel model,int[] categoryIds)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    IsApproved = false

                };
                var name = entity.Name;

                productService.Create(entity);


                var msg = new AlertModel()
                {
                    Message = name + " added.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("GetAll");
            }
            return View(model);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = productService.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                Name = entity.Name,
                Price = entity.Price,
                Categories = productService.GetAllCategory(),
                SelectedCategories = productService.SelectedCategories(entity.ProductId).ProductCategories.Select(x => x.Category).ToList()


            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ProductModel model,int[] categoryIds)
        {
            if (ModelState.IsValid)
            {
                var entity = productService.GetById(model.ProductId);
                entity.ImageUrl = model.ImageUrl;
                entity.Name = model.Name;
                entity.Price = model.Price;
                entity.Description = model.Description;

                var name = entity.Name;



                productService.Update(entity, categoryIds);


                var msg = new AlertModel()
                {
                    Message = name + " updated.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);
                
                return RedirectToAction("GetAll");
            }
            model.Categories = productService.GetAllCategory();
            return View(model);
        }
        [HttpPost]
        public IActionResult Remove(int? ProductId)
        {
            if (ProductId == null)
            {
                return NotFound();
            }
            var entity = productService.GetById((int)ProductId);
            var name = entity.Name;
            if (entity == null)
            {
                return NotFound();
            }

            productService.Remove(entity);

            var msg = new AlertModel()
            {
                Message =  name+" removed.",
                AlertType = "danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);


            return RedirectToAction("GetAll");
        }
    }
}
