using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tiajsmith.Controllers
{
    public class MyHangmanController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Return an empty registration view
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        
    }
}