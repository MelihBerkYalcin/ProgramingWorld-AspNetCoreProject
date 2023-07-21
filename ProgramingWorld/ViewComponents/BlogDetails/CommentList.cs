using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.BlogDetails
{
    public class CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke(int ID)
        {
            return View(commentManager.GetedID(ID).OrderByDescending(I => I.CommentID).ToList());
        }
    }
}
