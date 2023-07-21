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
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EFMessageRepository());
        Context context = new Context();

        public void GetedMessageCount()
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();

            ViewBag.SenderMessageCount = context.Message.Where(I => I.ReceiverUserId == AdminID).Select(I => I.MessageID).Count();
            ViewBag.ReceiverMessageCount = context.Message.Where(I => I.SenderUserId == AdminID).Select(I => I.MessageID).Count();
            ViewBag.AllMessage = context.Message.Select(I => I.MessageID).Count();
        }

        public IActionResult SenderBoxMessage()
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            
            GetedMessageCount();

            return View(messageManager.GetByWriterWithMessage(AdminID).OrderByDescending(I => I.MessageID).ToList());
        }

        public IActionResult ReceiverBoxMessage()
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();

            GetedMessageCount();

            return View(messageManager.WriterSendBox(AdminID).OrderByDescending(I => I.MessageID).ToList());
        }

        public IActionResult WriterAllMessage()
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();

            GetedMessageCount();

            return View(messageManager.WriterAllMessages().OrderByDescending(I => I.MessageID).ToList());
        }

        [HttpGet]
        public IActionResult MessageAdded()
        {
            GetedMessageCount();

            return View();
        }

        [HttpPost]
        public IActionResult MessageAdded(Message message, string ReceiverUserName)
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();
            var ReceiverID = context.Users.Where(I => I.UserName == ReceiverUserName).Select(I => I.Id).FirstOrDefault();

            if (ReceiverID != 0)
            {
                if (AdminID != ReceiverID)
                {
                    message.MessageStatus = true;
                    message.SenderUserId = AdminID;
                    message.ReceiverUserId = ReceiverID;
                    message.MessageDate = DateTime.Now;
                    messageManager.TAdd(message);
                    return RedirectToAction("ReceiverBoxMessage", "Message");
                }
            }

            GetedMessageCount();

            return View();
        }

        public IActionResult MessageDetails(int ID)
        {
            GetedMessageCount();
            return View(messageManager.GetByWriterWithMessage(ID));
        }

        public IActionResult ReceiverMessageDetails(int ID)
        {
            GetedMessageCount();
            return View(messageManager.GetByID(ID));
        }

        public IActionResult WriterAllMessageDetails(int ID)
        {
            GetedMessageCount();
            return View(messageManager.GetByID(ID));
        }

        [HttpPost]
        public IActionResult MessageDelete(int ID)
        {
            messageManager.TDelete(new Message { MessageID = ID });
            return RedirectToAction("SenderBoxMessage", "Message");
        }

        [HttpPost]
        public IActionResult MessageUpdate(Message message)
        {
            var UserName = User.Identity.Name;
            var AdminID = context.Users.Where(I => I.UserName == UserName).Select(I => I.Id).FirstOrDefault();

            message.MessageDate = DateTime.Now;
            message.MessageStatus = true;
            message.SenderUserId = AdminID;
            messageManager.TUpdate(message);
            return RedirectToAction("ReceiverBoxMessage", "Message");
        }

    }
}
