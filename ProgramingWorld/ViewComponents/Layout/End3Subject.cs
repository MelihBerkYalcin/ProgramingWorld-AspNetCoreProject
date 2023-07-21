using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class End3Subject : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            return View(blogManager.BlogWithCategoryGet().OrderByDescending(I=>I.BlogID).Take(3).ToList());
        }
    }
}
