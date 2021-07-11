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
    public class ContactTextController : Controller
    {
        private readonly IContactTextRepository _contactTextRepository;

        public ContactTextController(IContactTextRepository contactTextRepository)
        {
            _contactTextRepository = contactTextRepository;
        }
        public IActionResult Index()
        {
            return View(_contactTextRepository.GetAll().FirstOrDefault());
        }
        [HttpGet]
        public IActionResult Update(Guid id)
        {

            return View(_contactTextRepository.GetById(id));
        }


        [HttpPost]
        public IActionResult Update(ContactText model)
        {
            if (ModelState.IsValid)
            {
                _contactTextRepository.Update(model);
                return RedirectToAction("Index", "ContactText");
            }
            return View(model);
        }
    }
}
