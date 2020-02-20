using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
{
    [Route("account")]
    public class BankController: Controller
    {
        private HomeContext dbContext;

        public BankController(HomeContext context)
        {
            dbContext = context;
        }
        private User LoggedIn()
        {
            return dbContext.Users.Include( u => u.MyTransactions).FirstOrDefault(
                        u => u.UserId == HttpContext.Session.GetInt32("UserId"));
        }

        [HttpGet("{userid}")]
        public IActionResult Index()
        {
            User userInDb = LoggedIn();
            if(userInDb == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            ViewBag.User = userInDb;
            ViewBag.Balance = userInDb.MyTransactions.Sum(t => t.Amount);
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Transaction transAmount)
        {
            User dbUser = LoggedIn();
            if(dbUser == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            
            
            if(ModelState.IsValid)
            {
                double bal = dbUser.MyTransactions.Sum(t => t.Amount);
                if(bal + transAmount.Amount < 0)
                {
                    ModelState.AddModelError("Amount", "You is out of funds homie go get that bag");
                    ViewBag.User = dbUser;
                    ViewBag.Balance = bal;
                    return View("Index");
                }
                else//complete transaction
                {
                    dbContext.Transactions.Add(transAmount);
                    dbContext.SaveChanges();
                    return Redirect($"/account/{dbUser.UserId}");
                }
            }
            else 
            {
                ViewBag.User = dbUser;
                ViewBag.Balance = dbUser.MyTransactions.Sum(t => t.Amount);
                return View("Index");
            }
        }
    }
}