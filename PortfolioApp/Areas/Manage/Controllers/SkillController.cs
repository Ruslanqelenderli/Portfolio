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
    public class SkillController : Controller
    {
        private readonly ISkillRepository _iSkillRepository;

        public SkillController(ISkillRepository iSkillRepository)
        {
            _iSkillRepository = iSkillRepository;
        }
        public IActionResult Index()
        {
            return View(_iSkillRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Skill model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _iSkillRepository.Add(model);
                return RedirectToAction("Index", "Skill");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Update(Guid id)
        {

            return View(_iSkillRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(Skill model)
        {
            if (ModelState.IsValid)
            {
                _iSkillRepository.Update(model);
                return RedirectToAction("Index", "Skill");
            }
            return View(model);
        }

        
        public IActionResult Delete(Guid id)
        {
            _iSkillRepository.Delete(_iSkillRepository.GetById(id));
            return  RedirectToAction("Index", "Skill");
        }
    }
}
