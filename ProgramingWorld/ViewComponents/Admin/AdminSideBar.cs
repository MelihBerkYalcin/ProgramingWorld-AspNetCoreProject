using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Admin
{
    public class AdminSideBar : ViewComponent
    {
        AppUserManager appUserManager = new AppUserManager(new EFAppUserRepository());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(appUserManager.GetUserByID(WriterID));
        }
    }
}
