﻿using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.ViewModels;

namespace Shortly.Client.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Login() 
        {
            var initial = new LoginVM();
            return View(initial);
        }

        public IActionResult LoginSubmitted(LoginVM loginVM)
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
