using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PortfolioApp.DAL;
using PortfolioApp.Models;
using PortfolioApp.Models.ViewModels;
using PortfolioApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public HomeController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }
        public IActionResult Index()
        {
            var result = from proj in _portfolioDbContext.Projects.ToList()
                         join category in _portfolioDbContext.ProjectCategories.ToList() on proj.ProjectCategoryId equals category.Id
                         select new ProjectViewModel { Id = proj.Id, CategoryId = category.Id, CategoryName = category.Name, Name = proj.Name, Info = proj.Info, Client = proj.Client, PhotoName = proj.PhotoName, Url = proj.Url, CreateDate = proj.CreateDate.Value };
            var onePage = new OnePageViewModel()
            {
                About = _portfolioDbContext.Abouts.FirstOrDefault(),
                SkillText = _portfolioDbContext.SkillTexts.FirstOrDefault(),
                Skills = _portfolioDbContext.Skills.OrderByDescending(x => x.Point).ToList(),
                Educations = _portfolioDbContext.Educations.ToList(),
                ResumeText = _portfolioDbContext.ResumeTexts.FirstOrDefault(),
                ServiceText = _portfolioDbContext.ServiceTexts.FirstOrDefault(),
                ContactText = _portfolioDbContext.ContactTexts.FirstOrDefault(),
                Services = _portfolioDbContext.Services.ToList(),
                Abouts = _portfolioDbContext.Abouts.ToList(),
                Categories = _portfolioDbContext.ProjectCategories.ToList(),
                Projects = _portfolioDbContext.Projects.ToList(),
                ProjectTexts = _portfolioDbContext.ProjectTexts.ToList().FirstOrDefault(),
                ProjectViewModels= result.ToList()

            };
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }
            



            return View(onePage);
        }


        
        public IActionResult Details(Guid id)
        {

            var result = from proj in _portfolioDbContext.Projects.ToList()
                         join category in _portfolioDbContext.ProjectCategories.ToList() on proj.ProjectCategoryId equals category.Id
                         select new ProjectViewModel { Id = proj.Id, CategoryId = category.Id, CategoryName = category.Name, Name = proj.Name, Info = proj.Info, Client = proj.Client, PhotoName = proj.PhotoName, Url = proj.Url, CreateDate = proj.CreateDate.Value };
            var project = result.FirstOrDefault(x => x.Id == id);
            return View(project);
        }

        [HttpPost]
        public IActionResult SendMail(SendMail obj)
        {

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress("Ruslan Qelenderli", "rqelenderli7@gmail.com"));
            message.To.Add(new MailboxAddress("Ruslan Qelenderli", "rqelenderli7@gmail.com"));
            message.Subject = obj.Subject;
            message.Body = new TextPart("plain")
            {
                Text = obj.Message + "My email address:" + obj.Email
            };
            using (var client = new SmtpClient())
            {

                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("rqelenderli7@gmail.com", "bal0101+!");
                client.Send(message);
                client.Disconnect(true);
            }
            TempData["Message"] = "Message sent.";


            return RedirectToAction("Index");
        }
    }
}
