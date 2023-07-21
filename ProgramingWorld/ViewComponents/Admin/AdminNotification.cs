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
    public class AdminNotification : ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            ViewBag.Notification = context.Notification.Count();
            return View(notificationManager.Listed());
        }
    }
}
