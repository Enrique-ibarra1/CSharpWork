using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomPassword.Models;

namespace RandomPassword.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Count") == null)
            {
                HttpContext.Session.SetInt32("Count",1);
            }
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string password = "";
            for(int i =0; i< 10; i++)
            {
                password += (characters[random.Next(characters.Length)]);
            }
            ViewBag.Pass = password;
            return View();
        }

        [HttpGet("generate")]
        public IActionResult Generate()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count++;
            HttpContext.Session.SetInt32("Count", (int)count);
            return RedirectToAction("Index");
        }
    }
}
