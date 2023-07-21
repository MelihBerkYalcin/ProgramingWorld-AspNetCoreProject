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
    public class CommentReplyController : Controller
    {
        CommentReplyManager commentReplyManager = new CommentReplyManager(new EFCommentReplyRepository());

        public IActionResult CommentReplyAdded(CommentReply commentReply)
        {
            commentReply.CommentReplyDate = DateTime.Now;
            commentReply.CommentReplyStatus = true;
            commentReplyManager.TAdd(commentReply);
            return View();
        }
    }
}
