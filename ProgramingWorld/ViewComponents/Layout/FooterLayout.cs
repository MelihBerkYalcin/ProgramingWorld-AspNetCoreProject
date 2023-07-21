using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class FooterLayout : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());
        public IViewComponentResult Invoke()
        {
            return View(aboutManager.Listed());
        }
    }
}
