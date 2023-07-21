using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());
        Context context = new Context();

        public IActionResult NotificationAll()
        {
            return View(notificationManager.Listed());
        }

        public IActionResult NotificationDetails(int ID)
        {
            return View(notificationManager.GetID(ID));
        }

        [HttpGet]
        public IActionResult NotificationAdded()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NotificationAdded(Notification notification)
        {
            notification.NotificationDate = DateTime.Now;
            notification.NotificationStatus = true;
            notificationManager.TAdd(notification);
            return RedirectToAction("NotificationAll", "Notification");
        }

        [HttpGet]
        public IActionResult NotificationUpdated(int ID)
        {
            return View(notificationManager.GetID(ID));
        }

        [HttpPost]
        public IActionResult NotificationUpdated(Notification notification)
        {
            notification.NotificationDate = DateTime.Now;
            notification.NotificationStatus = true;
            notificationManager.TUpdate(notification);
            return RedirectToAction("NotificationAll", "Notification");
        }

        public IActionResult NotificationDeleted(int ID)
        {
            notificationManager.TDelete(new Notification { NotificationID = ID });
            return RedirectToAction("NotificationAll", "Notification");
        }
    }
}
