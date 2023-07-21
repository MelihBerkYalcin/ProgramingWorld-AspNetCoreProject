using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class LeftSocialMedia : ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaRepository());
        public IViewComponentResult Invoke()
        {
            return View(socialMediaManager.Listed());
        }
    }
}
