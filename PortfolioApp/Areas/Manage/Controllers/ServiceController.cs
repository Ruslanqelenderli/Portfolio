using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL;
using PortfolioApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Areas.Manage.Controllers
{
    [Area("Manage")]

    [Authorize]
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _iServiceRepository;

        public ServiceController(IServiceRepository iServiceRepository)
        {
            _iServiceRepository = iServiceRepository;
        }

        public IActionResult Index()
        {
            return View(_iServiceRepository.GetAll().ToList());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PortfolioApp.Models.Service model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _iServiceRepository.Add(model);
                return RedirectToAction("Index", "Service");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Update(Guid id)
        {

            return View(_iServiceRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(PortfolioApp.Models.Service model)
        {
            if (ModelState.IsValid)
            {
                _iServiceRepository.Update(model);
                return RedirectToAction("Index", "Service");
            }
            return View(model);
        }


        public IActionResult Delete(Guid id)
        {
            _iServiceRepository.Delete(_iServiceRepository.GetById(id));
            return RedirectToAction("Index", "Service");
        }
    }
}
