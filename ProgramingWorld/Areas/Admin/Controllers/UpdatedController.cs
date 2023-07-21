using BusinessLogicLayer.Concrete;
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
    public class UpdatedController : Controller
    {
        UpdatedListManager updatedListManager = new UpdatedListManager(new EFUpdateRepository());

        public IActionResult UpdatedList()
        {
            return View(updatedListManager.Listed().OrderByDescending(I=>I.UpdateID).ToList());
        }

        [HttpGet]
        public IActionResult UpdatedListAdded()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdatedListAdded(Update update)
        {
            update.UpdateDateTime = DateTime.Now;
            updatedListManager.TAdd(update);
            return RedirectToAction("UpdatedList", "Updated");
        }

        [HttpGet]
        public IActionResult UpdatedListUpdate(int ID)
        {
            return View(updatedListManager.GetID(ID));
        }

        [HttpPost]
        public IActionResult UpdatedListUpdated(Update update)
        {
            updatedListManager.TUpdate(update);
            return RedirectToAction("UpdatedList", "Updated");
        }

        public IActionResult UpdatedListDeleted(int ID)
        {
            updatedListManager.TDelete(new Update { UpdateID = ID });
            return RedirectToAction("UpdatedList", "Updated");
        }
    }
}
