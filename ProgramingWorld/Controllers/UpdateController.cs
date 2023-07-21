using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Controllers
{
    [AllowAnonymous]
    public class UpdateController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View(context.Updated.OrderByDescending(I=>I.UpdateID).ToList());
        }
    }
}
