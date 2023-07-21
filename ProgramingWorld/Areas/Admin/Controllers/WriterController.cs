using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProgramingWorld.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WriterController : Controller
    {
        AppUserManager appUserManager = new AppUserManager(new EFAppUserRepository());
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        Context context = new Context();
        public IActionResult WriterAll()
        {
            return View(appUserManager.Listed());
        }

        [HttpGet]
        public IActionResult WriterAdd()
        {
            List<SelectListItem> Liste = (from i in context.Roles.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Name,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.List = Liste;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WriterAdd(UserSignUpViewModel userSignUpViewModel)
        {
            List<SelectListItem> Liste = (from i in context.Roles.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Name,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.List = Liste;

            if (ModelState.IsValid == true)
            {
                AppUser user = new AppUser()
                {
                    Email = userSignUpViewModel.EMail,
                    UserName = userSignUpViewModel.UserName,
                    NameSurname = userSignUpViewModel.NameSurname,
                    PhoneNumber = userSignUpViewModel.PhoneNumber,
                    About = userSignUpViewModel.About,
                    Facebook = userSignUpViewModel.Facebook,
                    Instagram = userSignUpViewModel.Instagram,
                    Youtube = userSignUpViewModel.Youtube,
                    IMGURL = "/Images/ProfilIMG/writerdefault.png",
                };

                var result = await _userManager.CreateAsync(user, userSignUpViewModel.Password);

                if (result.Succeeded == true)
                {
                    return RedirectToAction("WriterAll", "Writer");
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

        [HttpGet]
        public IActionResult WriterUpdate(int ID)
        {
            List<SelectListItem> Liste = (from i in context.Roles.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Name,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.List = Liste;

            return View(appUserManager.GetUserByID(ID));
        }

        [HttpPost]
        public async Task<IActionResult> WriterUpdate(AppUser appUser, string Password)
        {
            List<SelectListItem> Liste = (from i in context.Roles.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Name,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.List = Liste;

            var update = await _userManager.FindByNameAsync(User.Identity.Name);
            update.NameSurname = appUser.NameSurname;
            update.UserName = appUser.UserName;
            update.Email = appUser.Email;
            update.PhoneNumber = appUser.PhoneNumber;
            update.Facebook = appUser.Facebook;
            update.Instagram = appUser.Instagram;
            update.Youtube = appUser.Youtube;
            update.IMGURL = appUser.IMGURL;
            update.About = appUser.About;
            update.PasswordHash = _userManager.PasswordHasher.HashPassword(update, Password);
            var result = await _userManager.UpdateAsync(update);
            return RedirectToAction("WriterAll", "Writer");
        }

        [HttpPost]
        public IActionResult WriterDelete(int ID)
        {
            appUserManager.TDelete(new AppUser { Id = ID });
            return RedirectToAction("WriterAll", "Writer");
        }

    }
}
