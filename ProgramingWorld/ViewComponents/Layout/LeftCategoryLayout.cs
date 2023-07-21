using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class LeftCategoryLayout : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke()
        {
            return View(categoryManager.Listed());
        }
    }
}
