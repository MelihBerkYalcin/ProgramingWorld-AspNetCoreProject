using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ProgramingWorld.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        Context context = new Context();

        public IActionResult Index(int page = 1)
        {
            return View(blogManager.BlogWithCategoryGet().OrderByDescending(I => I.BlogID).ToPagedList(page, 13));
        }

        public IActionResult BlogDetails(int ID)
        {
            ViewBag.X = ID;
            return View(blogManager.BlogAndCategoryGetList(I => I.BlogID == ID));
        }

        public IActionResult BlogCategoryGetList(int ID, int page = 1)
        {
            return View(blogManager.BlogAndCategoryGetList(I => I.CategoryID == ID).OrderByDescending(I => I.BlogID).ToPagedList(page, 15));
        }

        public IActionResult BlogSubCategory(int ID, int page = 1)
        {
            return View(blogManager.BlogAndSubCategoryGetList(I => I.SubCategoryID == ID).OrderByDescending(I => I.BlogID).ToPagedList(page, 15));
        }

        public IActionResult WriterBlogGet(int ID, int page = 1)
        {
            return View(blogManager.BlogAndCategoryGetList(I => I.AppUserId == ID).OrderByDescending(I => I.BlogID).ToPagedList(page, 15));
        }

        public IActionResult SearchBlog(string p, int page = 1)
        {
            return View(blogManager.BlogAndCategoryGetList(I => I.BlogTitle.Contains(p)).OrderByDescending(I => I.BlogID).ToPagedList(page, 15));
        }

        [HttpGet]
        public IActionResult EMailGetLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EMailGetLogin(string email)
        {
            var usersloginget = context.Users.Where(I => I.Email == email).Select(I => I.Id).FirstOrDefault();

            if (usersloginget > 0)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Index", "Blog");
            }
        }
    }
}
