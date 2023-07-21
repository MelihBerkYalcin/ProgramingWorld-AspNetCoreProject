using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.ViewComponents.Layout
{
    public class LeftReklam : ViewComponent
    {
        AdvertManager advertManager = new AdvertManager(new EFAdvertRepository());
        public IViewComponentResult Invoke()
        {
            return View(advertManager.Listed());
        }
    }
}
