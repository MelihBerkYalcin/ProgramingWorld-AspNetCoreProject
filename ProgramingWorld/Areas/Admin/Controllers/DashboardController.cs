using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        AppUserManager appUserManager = new AppUserManager(new EFAppUserRepository());
        Context context = new Context();

        public IActionResult Index()
        {
            ViewBag.Users = context.Users.Count();
            ViewBag.Blogs = context.Blog.Count();
            ViewBag.AllMessage = context.Message.Count();
            ViewBag.CommentAll = context.Comment.Count();
            ViewBag.Roller = context.Roles.Count();
            ViewBag.Category = context.Category.Count();

            ViewBag.Puan = context.Comment.Sum(I => I.BlogScore);

            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();

            return View(appUserManager.GetUserByID(WriterID));
        }
    }
}
