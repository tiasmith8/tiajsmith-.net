using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tiajsmith.DAL;
using tiajsmith.Models;

namespace tiajsmith.Controllers
{
    public class MyHangmanController : Controller
    {
        public UserSqlDAO userDAO;
        public MyHangmanController(UserSqlDAO userDAO)
        {
            this.userDAO = userDAO;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Return an empty registration view for the user to fill out
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: User/Login
        // Comes here to validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationViewModel model)
        {
            /* Place to enfore the rules */
            //Check to see if model is valid
            if (ModelState.IsValid)
            {
                //Save the new user to database
                userDAO.CreateUser(model.Email, model.Password);

                //Redirects the page to method Confirmation
                //return RedirectToAction("Confirmation");
                return RedirectToAction("Confirmation", model);
            }

            // Return to registration screen and send the data that didn't work
            // Tell the view to display again (with the existing data that was passed in)
            return View(model); //This time view will display all existing data with error messages
        }

        // GET: User/Confirmation
        // Return the confirmation view that registration was successful and new user created.
        [HttpGet]
        public IActionResult Confirmation(RegistrationViewModel model)
        {
            return View(model);
        }

        // GET: User/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: User/Login submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            // If Login is sucessful - redirect to Game Page
            if(ModelState.IsValid)
            {
                // Check that the username and password are correct
                User user = userDAO.GetUser(model.Email);
                if (user != null && user.Password.Equals(model.Password))
                {
                    return RedirectToAction("Game");
                }
                else
                {
                    // Send tempdata message that username/password are incorrect
                    TempData["login_message"] = "*The email and/or password provided is incorrect.";
                    return View(model);
                }
            }

            // If Login is not successful - send back to Login page
            else
            {
                TempData["login_message"] = "*The email and/or password provided is incorrect.";
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Game()
        {
            return View();
        }

    }
}