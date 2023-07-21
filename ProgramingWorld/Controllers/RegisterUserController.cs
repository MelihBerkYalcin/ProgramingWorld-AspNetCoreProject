using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgramingWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registry(UserSignUpViewModel userSignUpViewModel)
        {
            if (ModelState.IsValid == true)
            {
                AppUser user = new AppUser()
                {
                    Email = userSignUpViewModel.EMail,
                    UserName = userSignUpViewModel.UserName,
                    NameSurname = userSignUpViewModel.NameSurname,
                };

                var result = await _userManager.CreateAsync(user, userSignUpViewModel.Password);

                if (result.Succeeded == true)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userSignUpViewModel);
        }
    }
}
