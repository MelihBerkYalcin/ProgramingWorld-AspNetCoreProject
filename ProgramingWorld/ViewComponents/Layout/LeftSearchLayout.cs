using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class LeftSearchLayout : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke(string p)
        {
            return View(blogManager.BlogAndCategoryGetList(I=>I.BlogTitle.Contains(p)).OrderByDescending(I=>I.BlogID).ToList());
        }
    }
}
