using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProgramingWorld.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Controllers
{
    [Authorize(Roles = "Admin,Moderatör,Erkek Yazar,Bayan Yazar")]
    public class WriterController : Controller
    {
        AppUserManager appUserManager = new AppUserManager(new EFAppUserRepository());
        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        MessageManager messageManager = new MessageManager(new EFMessageRepository());
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());
        CommentManager commentManager = new CommentManager(new EFCommentRepository());
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        Context context = new Context();

        public WriterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // WRİTER DASHBOARD KISMI
        public IActionResult Dashboard()
        {
            var WriterName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == WriterName).Select(I => I.Id).FirstOrDefault();

            ViewBag.ToplamBlog = context.Blog.Count();
            ViewBag.KisiBlog = context.Blog.Where(I => I.AppUserId == WriterID).Select(I => I.BlogID).Count();
            ViewBag.ToplamYorum = context.Comment.Where(I => I.Blog.AppUserId == WriterID).Select(I => I.CommentID).Count();
            return View(appUserManager.GetUserByID(WriterID));
        }
        // WRİTER DASHBOARD KISMI BİTTİ

        public IActionResult Profile()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(appUserManager.GetUserByID(WriterID));
        }

        [HttpPost]
        public async Task<IActionResult> ProfileUpdate(AppUser appUser, string Password, IFormFile formFile)
        {
            if (formFile != null)
            {
                var extension = Path.GetExtension(formFile.FileName);
                var newimagesname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/ProfilIMG/", newimagesname);
                var stream = new FileStream(location, FileMode.Create);
                formFile.CopyTo(stream);
                appUser.IMGURL = "/Images/ProfilIMG/" + newimagesname;
            }

            #region
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
            return RedirectToAction("Profile", "Writer");
            #endregion
        }

        public IActionResult WriterGetBlogList()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(blogManager.BlogAndCategoryGetList(I => I.AppUserId == WriterID).OrderByDescending(I => I.BlogID).ToList());
        }

        [HttpGet]
        public IActionResult WriterBlogAdded()
        {
            List<SelectListItem> Liste = (from i in context.Category.ToList()
                                          select new SelectListItem
                                          {
                                              Value = i.CategoryID.ToString(),
                                              Text = i.CategoryName,
                                          }).ToList();
            ViewBag.List = Liste;

            List<SelectListItem> SubCategoryList = (from i in context.SubCategory.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Value = i.SubCategoryID.ToString(),
                                                        Text = i.SubCategoryName,
                                                    }).ToList();

            ViewBag.ListSubCategory = SubCategoryList;

            return View();
        }

        [HttpPost]
        public IActionResult WriterBlogAdded(Blog blog, IFormFile formFile)
        {
            List<SelectListItem> Liste = (from i in context.Category.ToList()
                                          select new SelectListItem
                                          {
                                              Value = i.CategoryID.ToString(),
                                              Text = i.CategoryName,
                                          }).ToList();
            ViewBag.List = Liste;

            List<SelectListItem> SubCategoryList = (from i in context.SubCategory.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Value = i.SubCategoryID.ToString(),
                                                        Text = i.SubCategoryName,
                                                    }).ToList();

            ViewBag.ListSubCategory = SubCategoryList;

            if (formFile != null)
            {
                var extension = Path.GetExtension(formFile.FileName);
                var newimagesname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/BlogIMG/", newimagesname);
                var stream = new FileStream(location, FileMode.Create);
                formFile.CopyTo(stream);
                blog.BlogIMGURL = "/Images/BlogIMG/" + newimagesname;
            }

            var UserName = User.Identity.Name;
            blog.AppUserId = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            blog.BlogCreateDate = DateTime.Now;
            blog.BlogStatus = true;
            blogManager.TAdd(blog);
            return RedirectToAction("WriterGetBlogList", "Writer");
        }

        [HttpGet]
        public IActionResult WriterMessageAdded()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterMessageAdded(Message message, string ReceiverUserName)
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            var ReceiverID = context.Users.Where(I => I.UserName == ReceiverUserName).Select(I => I.Id).FirstOrDefault();

            if (ReceiverID != 0)
            {
                if (WriterID != ReceiverID)
                {
                    message.SenderUserId = WriterID;
                    message.ReceiverUserId = ReceiverID;
                    message.MessageDate = DateTime.Now;
                    message.MessageStatus = true;
                    messageManager.TAdd(message);
                    return RedirectToAction("WriterSendBox", "Writer");
                }
            }
            return View();
        }

        public IActionResult WriterInBox()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(messageManager.GetByWriterWithMessage(WriterID).OrderByDescending(I => I.MessageID).ToList());
        }

        public IActionResult WriterSendBox()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(messageManager.WriterSendBox(WriterID).OrderByDescending(I => I.MessageID).ToList());
        }

        public IActionResult MessageDetails(int ID)
        {
            return View(messageManager.WriterGetByMessage(ID));
        }

        public IActionResult MessageDetailss(int ID)
        {
            return View(messageManager.WriterGetByMessage(ID));
        }

        public IActionResult WriterBlogDelete(int ID)
        {
            blogManager.TDelete(new Blog { BlogID = ID });
            return RedirectToAction("WriterGetBlogList", "Writer");
        }

        [HttpGet]
        public IActionResult WriterBlogUpdate(int ID)
        {
            List<SelectListItem> Liste = (from i in context.Category.ToList()
                                          select new SelectListItem
                                          {
                                              Value = i.CategoryID.ToString(),
                                              Text = i.CategoryName,
                                          }).ToList();
            ViewBag.List = Liste;

            List<SelectListItem> SubCategoryList = (from i in context.SubCategory.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Value = i.SubCategoryID.ToString(),
                                                        Text = i.SubCategoryName,
                                                    }).ToList();

            ViewBag.ListSubCategory = SubCategoryList;

            return View(blogManager.GetID(ID));
        }

        [HttpPost]
        public IActionResult WriterBlogUpdated(Blog blog, IFormFile formFile)
        {
            List<SelectListItem> Liste = (from i in context.Category.ToList()
                                          select new SelectListItem
                                          {
                                              Value = i.CategoryID.ToString(),
                                              Text = i.CategoryName,
                                          }).ToList();
            ViewBag.List = Liste;

            List<SelectListItem> SubCategoryList = (from i in context.SubCategory.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Value = i.SubCategoryID.ToString(),
                                                        Text = i.SubCategoryName,
                                                    }).ToList();

            ViewBag.ListSubCategory = SubCategoryList;

            if (formFile != null)
            {
                var extension = Path.GetExtension(formFile.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/BlogIMG/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                formFile.CopyTo(stream);
                blog.BlogIMGURL = "/Images/BlogIMG/" + newimagename;
            }

            var UserName = User.Identity.Name;
            blog.AppUserId = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            blog.BlogCreateDate = DateTime.Now;
            blog.BlogStatus = true;
            blogManager.TUpdate(blog);
            return RedirectToAction("WriterGetBlogList", "Writer");
        }

        public IActionResult WriterMessageDelete(int ID)
        {
            messageManager.TDelete(new Message { MessageID = ID });
            return RedirectToAction("Dashboard", "Writer");
        }

        public IActionResult NotificationDetails(int ID)
        {
            return View(notificationManager.GetID(ID));
        }

        public IActionResult AllNotification()
        {
            return View(notificationManager.Listed());
        }

        public IActionResult Comment()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(blogManager.BlogAndCategoryGetList(I => I.AppUserId == WriterID).OrderByDescending(I => I.BlogID).ToList());
        }

        public IActionResult CommentAll(int ID)
        {
            return View(commentManager.CommentByID(ID).OrderByDescending(I => I.CommentID).ToList());
        }

        public IActionResult CommentDetails(int ID)
        {
            return View(commentManager.CommentGetByID(ID));
        }

        public IActionResult CommentDeleted(int ID)
        {
            commentManager.TDelete(new Comment { CommentID = ID });
            return RedirectToAction("Comment", "Writer");
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Blog");
        }

    }
}
