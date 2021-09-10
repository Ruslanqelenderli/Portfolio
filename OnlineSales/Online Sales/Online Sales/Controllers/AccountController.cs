using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Online_Sales.EmailServices;
using Online_Sales.İdentity;
using Online_Sales.Models;
using OnlineSalesBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.Controllers
{
    public class AccountController:Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService cartService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,IEmailSender emailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            this.cartService = cartService;

        }

        public  IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "There are no users with this name in the database.");
                return View(model);
            }

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Please confirm your membership with the link sent to your email account.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                
                return RedirectToAction("GetAll", "Admin");
            }
            ModelState.AddModelError("", "The username or password entered is incorrect");
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
               
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });

                //_emailSender.SendEmail2(model.Email, "Confirm your account.", $"Please <a href='https://localhost:5001{url}'>click</a> the link to confirm your email account. ");
                EmailSend email = new EmailSend();
                email.Send(model.Email, "Confirm your account.", $"Please <a href='https://localhost:5001{url}'>click</a> the link to confirm your email account. ");
                return RedirectToAction("Login", "Account");
            }

            ModelState.AddModelError("", "Unknown error, please try again.");
            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if(userId==null || token == null)
            {
                CreateMessage("Wrong token or user.", "danger");
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    cartService.InitializeCart(user.Id);
                    CreateMessage("Your account has been approved.", "succeed");
                    return View();
                }
            }
            CreateMessage("Your account has not been approved", "danger");
            return View();
        }


        public IActionResult Accessdenied()
        {
            return View();
        }

        private void CreateMessage(string message, string alerttype)
        {
            var msg = new AlertModel()
            {
                Message = message,
                AlertType = alerttype
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
        }


    }
}
