using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class LeftMaximumPuan3Subject : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            return View(context.Comment.Where(I => I.BlogScore > 50).Select(I => I.Blog).OrderByDescending(I => I.BlogID).ToList()); // Yorum Kısmı Ayarlanacak
        }
    }
}
