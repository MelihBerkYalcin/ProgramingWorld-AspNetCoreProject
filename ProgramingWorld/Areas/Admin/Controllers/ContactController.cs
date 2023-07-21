using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactRepository());

        public IActionResult ContactAll()
        {
            return View(contactManager.Listed());
        }

        public IActionResult ContactDeleted(int ID)
        {
            contactManager.TDelete(new Contact { ContactID = ID });
            return RedirectToAction("ContactAll", "Contact");
        }
        public IActionResult ContactDetails(int ID)
        {
            return View(contactManager.GetID(ID));
        }
    }
}
