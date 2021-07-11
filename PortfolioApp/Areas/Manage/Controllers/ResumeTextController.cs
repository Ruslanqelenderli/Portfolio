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
    public class ResumeTextController : Controller
    {
        private readonly IResumeTextRepository _iResumeTextRepository;

        public ResumeTextController(IResumeTextRepository iResumeTextRepository)
        {
            _iResumeTextRepository = iResumeTextRepository;
        }
        public IActionResult Index()
        {
            return View(_iResumeTextRepository.GetAll().FirstOrDefault());
        }
        [HttpGet]
        public IActionResult Update(Guid id)
        {

            return View(_iResumeTextRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(ResumeText model)
        {
            if (ModelState.IsValid)
            {
                _iResumeTextRepository.Update(model);
                return RedirectToAction("Index", "ResumeText");
            }
            return View(model);
        }
    }
}
