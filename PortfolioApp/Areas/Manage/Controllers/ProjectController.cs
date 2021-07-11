using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Interface;
using PortfolioApp.Models;
using PortfolioApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository repository;
        private readonly IProjectCategoryRepository categoryRepository;
        private readonly IWebHostEnvironment webHost;
        public ProjectController(IProjectRepository repository, IWebHostEnvironment webHost, IProjectCategoryRepository categoryRepository)
        {
            this.repository = repository;
            this.webHost = webHost;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var model = repository.GetAll();
            var result = from proj in repository.GetAll()
                         join category in categoryRepository.GetAll() on proj.ProjectCategoryId equals category.Id
                         select new ProjectViewModel { Id = proj.Id, CategoryId = category.Id, CategoryName = category.Name, Name = proj.Name, Info = proj.Info,Client=proj.Client,PhotoName=proj.PhotoName,Url=proj.Url,CreateDate=proj.CreateDate.Value };
            return View(result);
        }

        public IActionResult Add()
        {
            var model = categoryRepository.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(Project model)
        {
            var newFileName = "";
            if (model.Photo != null)
            {
                newFileName =
             $"{Path.GetFileNameWithoutExtension(model.Photo.FileName)}" +
             $"-{DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss")}" +
             $"{Path.GetExtension(model.Photo.FileName)}";

                var rootPath = Path.Combine(webHost.WebRootPath, "img", newFileName);
                using (var fileStream = new FileStream(rootPath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }
            if (ModelState.IsValid)
            {
                model.PhotoName = newFileName;
                model.CreateDate = DateTime.Now;
                repository.Add(model);
                return RedirectToAction("Index", "Project");
            }
            
            return View(model);
        }



        public IActionResult Update(Guid id)
        {
            var model =repository.GetById(id);
            var categories = categoryRepository.GetAll();
            var ViewModel = new ProjectUpdateViewModel()
            {
                Projects = model,
                ProjectCategories = categories
            };
            return View(ViewModel);
        }
        [HttpPost]
        public IActionResult Update(Project model)
        {
            var newFileName = "";
            if (model.Photo != null)
            {
                newFileName =
             $"{Path.GetFileNameWithoutExtension(model.Photo.FileName)}" +
             $"-{DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss")}" +
             $"{Path.GetExtension(model.Photo.FileName)}";

                var rootPath = Path.Combine(webHost.WebRootPath, "img", newFileName);
                using (var fileStream = new FileStream(rootPath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }
            if (ModelState.IsValid)
            {
                model.PhotoName = newFileName;
                model.CreateDate = DateTime.Now;
                repository.Add(model);
                return RedirectToAction("Index", "Project");
            }
            return View(model);
        }


        public IActionResult Delete(Guid id)
        {
            var model = repository.GetById(id);
            repository.Delete(model);

            return RedirectToAction("Index", "Project");
        }
    }
}
