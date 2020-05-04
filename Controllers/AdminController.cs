using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DubuisGelin.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UpCycling.Models.AdminController;
using UpCycling.Service.Interface;

namespace UpCycling.Controllers
{
    public class AdminController : Controller
    {
        public IUserService UserServices { get; }
        public IEventServices EventServices { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public ILogger<RegisterModel> Logger { get; }
        public IEmailSender EmailSender { get; }

        public AdminController(IUserService userServices,
            IEventServices eventServices,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            UserServices = userServices ?? throw new ArgumentNullException(nameof(userServices));
            EventServices = eventServices ?? throw new ArgumentNullException(nameof(eventServices));
            UserManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            SignInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            EmailSender = emailSender ?? throw new ArgumentNullException(nameof(emailSender));
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            var newUser = new CreateUserViewModel();
            return View(newUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(CreateUserViewModel createUser)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = createUser.Email, Email = createUser.Email };
                var result = await UserManager.CreateAsync(user, createUser.Password);
                if (result.Succeeded)
                {
                    await UserServices.CreateUser(createUser.Email);

                    await UserManager.AddToRoleAsync(user, "Admin");
                    await SignInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(createUser);
        }

        public IActionResult CreateEvent()
        {
            var newEvent = new CreateEventViewModel();
            return View(newEvent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEvent(CreateEventViewModel createEvent)
        {
            if (ModelState.IsValid)
            {
                EventServices.CreateEvent(createEvent.Nom, createEvent.Prix, createEvent.Date, createEvent.Desc, createEvent.Lieu, createEvent.Place);
                return RedirectToAction(nameof(Index));
             }
            return View(createEvent);
        }
    }
}