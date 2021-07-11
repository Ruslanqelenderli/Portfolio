using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Interface;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Areas.Manage.Controllers
{
    [Area("Manage")]

    [Authorize]
    public class ProjectCategoryController : Controller
    {
        private readonly IProjectCategoryRepository repository;
        public ProjectCategoryController(IProjectCategoryRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var all = repository.GetAll();
            return View(all);
        }
        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(ProjectCategory model)
        {
            if (ModelState.IsValid)
            {
                repository.Add(model);
                return RedirectToAction("Index", "ProjectCategory");
            }
            return View(model);
        }


        public IActionResult Update(Guid Id)
        {
            var model = repository.GetById(Id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(ProjectCategory model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                return RedirectToAction("Index", "ProjectCategory");
            }
            return View(model);
        }


        public IActionResult Delete(Guid id)
        {
            var model = repository.GetById(id);
            repository.Delete(model);
            return RedirectToAction("Index", "ProjectCategory");
        }
    }
}
