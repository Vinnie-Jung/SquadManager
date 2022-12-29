using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace squadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginPage()
        {
            return View("login");
        }
    }
}