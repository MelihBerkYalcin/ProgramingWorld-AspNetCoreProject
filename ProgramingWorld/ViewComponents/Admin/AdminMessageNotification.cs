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
    public class AdminMessageNotification : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EFMessageRepository());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            ViewBag.MessageCoung = context.Message.Where(I => I.ReceiverUserId == AdminID).Select(I => I.MessageID).FirstOrDefault();
            return View(messageManager.GetByWriterWithMessage(AdminID));
        }
    }
}
