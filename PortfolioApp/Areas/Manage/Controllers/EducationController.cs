using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL;
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


    public class EducationController : Controller
    {
        private readonly IEducationRepository _iEducationRepository;

        public EducationController(IEducationRepository iEducationRepository)
        {
            _iEducationRepository = iEducationRepository;
        }

        public IActionResult Index()
        {
            return View(_iEducationRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Education model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _iEducationRepository.Add(model);
                return RedirectToAction("Index", "Education");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Update(Guid id)
        {
            
            return View(_iEducationRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(Education model)
        {
            if (ModelState.IsValid)
            {
                _iEducationRepository.Update(model);
                return RedirectToAction("Index", "Education");
            }
            return View(model);
        }


        public IActionResult Delete(Guid id)
        {
            _iEducationRepository.Delete(_iEducationRepository.GetById(id));
            return RedirectToAction("Index", "Education");
        }
    }
}
