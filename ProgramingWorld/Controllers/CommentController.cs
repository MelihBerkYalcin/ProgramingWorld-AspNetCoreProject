using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());

        [HttpGet]
        public PartialViewResult CommentAdded()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult CommentAdded(Comment comment)
        {
            comment.CommentDate = DateTime.Now;
            comment.CommentStatus = false;
            commentManager.TAdd(comment);
            return RedirectToAction("Index", "Blog");
        }
    }
}
