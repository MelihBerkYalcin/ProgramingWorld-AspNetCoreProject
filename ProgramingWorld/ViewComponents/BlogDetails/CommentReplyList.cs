using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.BlogDetails
{
    public class CommentReplyList : ViewComponent
    {
        CommentReplyManager commentManager = new CommentReplyManager(new EFCommentReplyRepository());

        public IViewComponentResult Invoke(int Comment)
        {
            ViewBag.X = Comment;
            return View(commentManager.GetByCommentReplyID(I => I.CommentID == Comment).Select(I => I.CommentReplyID).ToList());
        }
    }
}
