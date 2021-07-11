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
    public class SkillTextController : Controller
    {
        private readonly ISkillTextRepository _iSkillTextRepository;

        public SkillTextController(ISkillTextRepository iSkillTextRepository)
        {
            _iSkillTextRepository = iSkillTextRepository;
        }
        public IActionResult Index()
        {
            return View(_iSkillTextRepository.GetAll().FirstOrDefault());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SkillText model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _iSkillTextRepository.Add(model);
                return RedirectToAction("Index","SkillText");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Update(Guid id)
        {
            
            return View(_iSkillTextRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(SkillText model)
        {
            if (ModelState.IsValid)
            {
                _iSkillTextRepository.Update(model);
                return RedirectToAction("Index", "SkillText");
            }
            return View(model);
        }

    }
}
