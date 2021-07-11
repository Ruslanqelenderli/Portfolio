using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL;
using PortfolioApp.Models;
using PortfolioApp.Repository;
using PortfolioApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioApp.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace PortfolioApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]
    public class AboutsController : Controller
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IWebHostEnvironment webHost;

        public AboutsController(IAboutRepository aboutRepository, IWebHostEnvironment webHost)
        {
            _aboutRepository = aboutRepository;
            this.webHost = webHost;
            
        }
       
        public IActionResult Index()
        {
            return View(_aboutRepository.GetAll());
        }

        
        
        
        [HttpGet]
        public IActionResult Update(Guid id)
        {
            var about = _aboutRepository.GetById(id);
           
            return View(about);
        }


        [HttpPost]
        public IActionResult Update(About model)
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
                _aboutRepository.Update(model);
                return RedirectToAction("Index", "SkillText");
            }
            return View(model);
        }


    }
}
