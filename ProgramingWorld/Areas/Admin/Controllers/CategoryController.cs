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
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
        Context context = new Context();

        public IActionResult CategoryList()
        {
            return View(categoryManager.Listed());
        }

        [HttpGet]
        public IActionResult CategoryAdded()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdded(Category category)
        {
            categoryManager.TAdd(category);
            return RedirectToAction("CategoryList", "Category");
        }

        [HttpGet]
        public IActionResult CategoryUpdate(int ID)
        {
            return View(categoryManager.GetID(ID));
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            categoryManager.TUpdate(category);
            return RedirectToAction("CategoryList", "Category");
        }

        [HttpPost]
        public IActionResult CategoryDelete(int ID)
        {
            categoryManager.TDelete(new Category { CategoryID = ID });
            return RedirectToAction("CategoryList", "Category");
        }
    }
}
