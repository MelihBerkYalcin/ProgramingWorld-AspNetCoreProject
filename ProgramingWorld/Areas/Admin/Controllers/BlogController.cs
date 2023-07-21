using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        Context context = new Context();

        public IActionResult Blog()
        {
            return View(blogManager.BlogWithCategoryGet().OrderByDescending(I => I.BlogID).ToList());
        }

        [HttpGet]
        public IActionResult BlogAdded()
        {
            List<SelectListItem> List = (from i in context.Category
                                         select new SelectListItem
                                         {
                                             Text = i.CategoryName,
                                             Value = i.CategoryID.ToString()
                                         }).ToList();
            ViewBag.Liste = List;

            List<SelectListItem> ListUser = (from i in context.Users
                                             select new SelectListItem
                                             {
                                                 Text = i.UserName,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.ListeUser = ListUser;

            List<SelectListItem> ListSubCategory = (from i in context.SubCategory
                                                    select new SelectListItem
                                                    {
                                                        Text = i.SubCategoryName,
                                                        Value = i.SubCategoryID.ToString(),
                                                    }).ToList();
            ViewBag.ListeSubCategory = ListSubCategory;

            return View();
        }

        [HttpPost]
        public IActionResult BlogAdded(Blog blog, IFormFile formFile)
        {
            if (formFile != null)
            {
                var extension = Path.GetExtension(formFile.FileName);
                var IMGUrlName = Guid.NewGuid() + extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/BlogIMG/", IMGUrlName);
                var Stream = new FileStream(Location, FileMode.Create);
                formFile.CopyTo(Stream);
                blog.BlogIMGURL = "/Images/BlogIMG/" + IMGUrlName;
            }

            List<SelectListItem> List = (from i in context.Category
                                         select new SelectListItem
                                         {
                                             Text = i.CategoryName,
                                             Value = i.CategoryID.ToString()
                                         }).ToList();
            ViewBag.Liste = List;

            List<SelectListItem> ListUser = (from i in context.Users
                                             select new SelectListItem
                                             {
                                                 Text = i.UserName,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.ListeUser = ListUser;

            List<SelectListItem> ListSubCategory = (from i in context.SubCategory
                                                    select new SelectListItem
                                                    {
                                                        Text = i.SubCategoryName,
                                                        Value = i.SubCategoryID.ToString(),
                                                    }).ToList();
            ViewBag.ListeSubCategory = ListSubCategory;

            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Now;
            blogManager.TAdd(blog);
            return RedirectToAction("Blog", "Blog");
        }

        [HttpGet]
        public IActionResult BlogUpdate(int ID)
        {
            List<SelectListItem> List = (from i in context.Category
                                         select new SelectListItem
                                         {
                                             Text = i.CategoryName,
                                             Value = i.CategoryID.ToString()
                                         }).ToList();
            ViewBag.Liste = List;

            List<SelectListItem> ListUser = (from i in context.Users
                                             select new SelectListItem
                                             {
                                                 Text = i.UserName,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.ListeUser = ListUser;

            List<SelectListItem> ListSubCategory = (from i in context.SubCategory
                                                    select new SelectListItem
                                                    {
                                                        Text = i.SubCategoryName,
                                                        Value = i.SubCategoryID.ToString(),
                                                    }).ToList();
            ViewBag.SubCategoryList = ListSubCategory;

            return View(blogManager.GetBlogById(ID));
        }

        [HttpPost]
        public IActionResult BlogUpdate(Blog blog,IFormFile formFile)
        {
            if (formFile != null)
            {
                var extension = Path.GetExtension(formFile.FileName);
                var IMGUrlName = Guid.NewGuid() + extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/BlogIMG/", IMGUrlName);
                var Stream = new FileStream(Location, FileMode.Create);
                formFile.CopyTo(Stream);
                blog.BlogIMGURL = "/Images/BlogIMG/" + IMGUrlName;
            }

            List<SelectListItem> List = (from i in context.Category
                                         select new SelectListItem
                                         {
                                             Text = i.CategoryName,
                                             Value = i.CategoryID.ToString()
                                         }).ToList();
            ViewBag.Liste = List;

            List<SelectListItem> ListUser = (from i in context.Users
                                             select new SelectListItem
                                             {
                                                 Text = i.UserName,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.ListeUser = ListUser;

            List<SelectListItem> ListSubCategory = (from i in context.SubCategory
                                                    select new SelectListItem
                                                    {
                                                        Text = i.SubCategoryName,
                                                        Value = i.SubCategoryID.ToString(),
                                                    }).ToList();
            ViewBag.SubCategoryList = ListSubCategory;

            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Now;
            blogManager.TUpdate(blog);
            return RedirectToAction("Blog", "Blog");
        }

        public IActionResult BlogDelete(int ID)
        {
            blogManager.TDelete(new Blog { BlogID = ID });
            return RedirectToAction("Blog", "Blog");
        }
    }
}
