using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgramingWorld.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RolController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        AppRoleManager appRoleManager = new AppRoleManager(new EFAppRoleRepository());
        Context context = new Context();

        public RolController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult RoleAll()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult RoleAdded()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleAdded(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                AppRole appRole = new AppRole
                {
                    Name = roleViewModel.Name,
                };

                var result = await _roleManager.CreateAsync(appRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleAll");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(roleViewModel);
        }

        [HttpGet]
        public IActionResult RoleUpdated(int ID)
        {
            var values = _roleManager.Roles.FirstOrDefault(I => I.Id == ID);
            RoleUpdateViewModel roleUpdateViewModel = new RoleUpdateViewModel
            {
                ID = values.Id,
                Name = values.Name,
            };
            return View(roleUpdateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RoleUpdated(RoleUpdateViewModel roleUpdateViewModel)
        {
            var values = _roleManager.Roles.Where(I => I.Id == roleUpdateViewModel.ID).FirstOrDefault();
            values.Name = roleUpdateViewModel.Name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("RoleAll", "Rol");

            }
            return View(roleUpdateViewModel);
        }

        public async Task<IActionResult> RoleDeleted(RoleUpdateViewModel roleUpdateViewModel)
        {
            var values = _roleManager.Roles.Where(I => I.Id == roleUpdateViewModel.ID).FirstOrDefault();
            var result = await _roleManager.DeleteAsync(values);
            return RedirectToAction("RoleAll", "Rol");
        }

        public IActionResult UserRoleList()
        {
            return View(_userManager.Users.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int ID)
        {
            var users = _userManager.Users.FirstOrDefault(I => I.Id == ID);
            var roles = _roleManager.Roles.ToList();

            TempData["Userid"] = users.Id;

            var userRoles = await _userManager.GetRolesAsync(users);
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel roleAssignView = new RoleAssignViewModel();
                roleAssignView.RoleID = item.Id;
                roleAssignView.Name = item.Name;
                roleAssignView.Exists = userRoles.Contains(item.Name);
                roleAssignViewModels.Add(roleAssignView);
            }
            return View(roleAssignViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> Models)
        {
            var userid = (int)TempData["Userid"];
            var user = _userManager.Users.FirstOrDefault(I => I.Id == userid);
            foreach (var item in Models)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserRoleList", "Rol");
        }

    }
}
