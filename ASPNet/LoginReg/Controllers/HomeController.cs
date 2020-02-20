using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private User LoggedIn()
        {
            return dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
        }
        private HomeContext dbContext;
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User register)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == register.Email))
                {
                    ModelState.AddModelError("Email", "Email has already been taken");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                register.Password = Hasher.HashPassword(register, register.Password);
                dbContext.Users.Add(register);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", register.UserId);
                return RedirectToAction("Success");

            }
            else 
            {
                return View("Index");
            }
        }

        [HttpGet("Success")]
        public IActionResult Success ()
        {
            User userInDb = LoggedIn();
            if(userInDb == null)
            {
                return RedirectToAction("Logout");
            }
            return View(userInDb);
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("signin")]
        public IActionResult SignIn(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                User dbUser = dbContext.Users.FirstOrDefault(u => u.Email == login.LoginEmail);
                if(dbContext.Users.Any(u => u.Email != login.LoginEmail))
                {
                    if(dbUser == null)
                    {
                        ModelState.AddModelError("LoginEmail", "Email or password not found");
                        return View("Login");
                    }
                }
                PasswordHasher<LoginUser> Hash = new PasswordHasher<LoginUser>();
                var result = Hash.VerifyHashedPassword(login, dbUser.Password, login.LoginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Email or password not found");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", dbUser.UserId);
                return RedirectToAction("Success");
            }
            else
            {
                return View("Login");
            }
        }
    }
}
