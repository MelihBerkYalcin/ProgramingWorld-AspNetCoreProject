using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubCategoryController : Controller
    {
        SubCategoryManager subCategoryManager = new SubCategoryManager(new EFSubCategoryRepository());
        Context context = new Context();

        public IActionResult SubCategoryList()
        {
            return View(subCategoryManager.SubCategoryListGetCategory());
        }

        [HttpGet]
        public IActionResult SubCategoryAdded()
        {
            List<SelectListItem> SubCategoryList = (from i in context.Category
                                                    select new SelectListItem
                                                    {
                                                        Text = i.CategoryName,
                                                        Value = i.CategoryID.ToString(),
                                                    }).ToList();

            ViewBag.Listed = SubCategoryList;

            return View();
        }

        [HttpPost]
        public IActionResult SubCategoryAdded(SubCategory subCategory)
        {
            List<SelectListItem> SubCategoryList = (from i in context.Category
                                                    select new SelectListItem
                                                    {
                                                        Text = i.CategoryName,
                                                        Value = i.CategoryID.ToString(),
                                                    }).ToList();

            ViewBag.Listed = SubCategoryList;

            subCategoryManager.TAdd(subCategory);
            return RedirectToAction("SubCategoryList", "SubCategory");
        }

        [HttpGet]
        public IActionResult SubCategoryUpdate(int ID)
        {
            List<SelectListItem> SubCategoryList = (from i in context.Category
                                                    select new SelectListItem
                                                    {
                                                        Text = i.CategoryName,
                                                        Value = i.CategoryID.ToString(),
                                                    }).ToList();

            ViewBag.Listed = SubCategoryList;

            return View(subCategoryManager.GetID(ID));
        }

        [HttpPost]
        public IActionResult SubCategoryUpdate(SubCategory subCategory)
        {
            List<SelectListItem> SubCategoryList = (from i in context.Category
                                                    select new SelectListItem
                                                    {
                                                        Text = i.CategoryName,
                                                        Value = i.CategoryID.ToString(),
                                                    }).ToList();

            ViewBag.Listed = SubCategoryList;

            subCategoryManager.TUpdate(subCategory);
            return RedirectToAction("SubCategoryList", "SubCategory");
        }

        public IActionResult SubCategoryDeleted(int ID)
        {
            subCategoryManager.TDelete(new SubCategory { SubCategoryID = ID });
            return RedirectToAction("SubCategoryList", "SubCategory");
        }
    }
}
