using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class SubCategoryLayout : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke(int ID)
        {
            ViewBag.X = ID;
            return View(context.SubCategory.Where(I => I.CategoryID == ID).ToList());
        }
    }
}
