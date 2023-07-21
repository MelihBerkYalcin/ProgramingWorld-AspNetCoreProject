using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());
        Context context = new Context();

        public IActionResult CommentAll()
        {
            return View(commentManager.CommentList());
        }

        [HttpGet]
        public IActionResult CommentAdded()
        {
            List<SelectListItem> List = (from i in context.Blog.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.BlogTitle,
                                             Value = i.BlogID.ToString(),
                                         }).ToList();
            ViewBag.Liste = List;
            return View();
        }

        [HttpPost]
        public IActionResult CommentAdded(Comment comment)
        {
            List<SelectListItem> List = (from i in context.Blog.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.BlogTitle,
                                             Value = i.BlogID.ToString(),
                                         }).ToList();
            ViewBag.Liste = List;

            comment.CommentStatus = false;
            comment.CommentDate = DateTime.Now;
            commentManager.TAdd(comment);
            return RedirectToAction("CommentAll", "Comment");
        }

        [HttpGet]
        public IActionResult CommentUpdated(int ID)
        {
            List<SelectListItem> List = (from i in context.Blog.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.BlogTitle,
                                             Value = i.BlogID.ToString(),
                                         }).ToList();
            ViewBag.Liste = List;

            return View(commentManager.GetCommentByBlog(ID));
        }

        [HttpPost]
        public IActionResult CommentUpdated(Comment comment)
        {
            List<SelectListItem> List = (from i in context.Blog.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.BlogTitle,
                                             Value = i.BlogID.ToString(),
                                         }).ToList();
            ViewBag.Liste = List;

            comment.CommentStatus = false;
            comment.CommentDate = DateTime.Now;
            commentManager.TUpdate(comment);
            return RedirectToAction("CommentAll", "Comment");
        }

        public IActionResult CommentDeleted(int ID)
        {
            commentManager.TDelete(new Comment { CommentID = ID });
            return RedirectToAction("CommentAll", "Comment");
        }
    }
}
