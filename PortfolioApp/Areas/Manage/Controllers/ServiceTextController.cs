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
    public class ServiceTextController : Controller
    {
        private readonly IServiceTextRepository _iServiceTextRepository;

        public ServiceTextController(IServiceTextRepository iServiceTextRepository)
        {
            _iServiceTextRepository = iServiceTextRepository;
        }
        public IActionResult Index()
        {
            return View(_iServiceTextRepository.GetAll().FirstOrDefault());
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {

            return View(_iServiceTextRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(PortfolioApp.Models.ServiceText model)
        {
            if (ModelState.IsValid)
            {
                _iServiceTextRepository.Update(model);
                return RedirectToAction("Index", "ServiceText");
            }
            return View(model);
        }
    }
}
