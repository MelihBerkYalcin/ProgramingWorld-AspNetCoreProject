using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Writer
{
    public class WriterAbout : ViewComponent
    {
        Context context = new Context();
        AppUserManager userManager = new AppUserManager(new EFAppUserRepository());
        public IViewComponentResult Invoke()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(userManager.GetUserByID(WriterID));
        }
    }
}
