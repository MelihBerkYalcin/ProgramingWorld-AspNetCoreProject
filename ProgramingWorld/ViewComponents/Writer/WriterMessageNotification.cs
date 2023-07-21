using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Context context = new Context();
        MessageManager messageManager = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            var UserName = User.Identity.Name;
            var WriterID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            return View(messageManager.GetByWriterWithMessage(WriterID).OrderByDescending(I=>I.MessageID).ToList());
        }
    }
}
