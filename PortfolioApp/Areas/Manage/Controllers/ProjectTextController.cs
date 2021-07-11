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
    public class ProjectTextController : Controller
    {
        private readonly IProjectTextRepository repository;
        public ProjectTextController(IProjectTextRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var model = repository.GetAll().FirstOrDefault();
            return View(model);
        }


        
        


        public IActionResult Update(Guid Id)
        {
            var model = repository.GetById(Id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(ProjectText model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                return RedirectToAction("Index", "ProjectText");
            }
            return View(model);
        }

    }
}
