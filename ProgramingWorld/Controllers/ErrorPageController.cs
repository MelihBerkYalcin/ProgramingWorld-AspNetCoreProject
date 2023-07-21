using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Controllers
{
    public class ErrorPageController : Controller
    {
        [AllowAnonymous]
        [Route("/ErrorPage/Error1/{statusCode}")]
        public IActionResult Error1(int statusCode)
        {
            return View();
        }
    }
}
