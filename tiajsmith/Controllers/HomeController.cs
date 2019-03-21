using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tiajsmith.Models;

namespace tiajsmith.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Splash page with enter button
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Portfolio page with website pictures and links
        /// </summary>
        /// <returns></returns>
        public IActionResult Landing()
        {
            return View();
        }

        /// <summary>
        /// Landing page with the about information
        /// </summary>
        /// <returns></returns>
        public IActionResult AboutMe()
        {
            return View();
        }


        /// <summary>
        /// Contact information page with ways to connect.
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            // ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Gallery of pictures view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Gallery()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
