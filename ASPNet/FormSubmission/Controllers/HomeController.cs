﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {   
            if(ModelState.IsValid)
            {
                User registerUser = newUser;
                return View("success", registerUser);
            }
            else 
            {
                return View("index");
            }
            
        }

        [HttpGet("success")]
        public ViewResult Success()
        {
            return View("success");
        }

        
    }
}
