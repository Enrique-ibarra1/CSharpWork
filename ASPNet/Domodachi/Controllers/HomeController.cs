using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Domodachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Fullness") == null &&
            HttpContext.Session.GetInt32("Happiness") == null &&
            HttpContext.Session.GetInt32("Meals") == null &&
            HttpContext.Session.GetInt32("Energy") == null)
            {
                HttpContext.Session.SetInt32("Fullness", 20);
                HttpContext.Session.SetInt32("Happiness", 20);
                HttpContext.Session.SetInt32("Meals", 3);
                HttpContext.Session.SetInt32("Energy", 50);
            }
            if(HttpContext.Session.GetInt32("Fullness") > 99 &&
            HttpContext.Session.GetInt32("Happiness") > 99 && 
            HttpContext.Session.GetInt32("Energy") > 99)
            {
                TempData["Message"] = "You win! restart?";
                return View();
            }
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Message = TempData["Message"];
            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Random rand = new Random();
            int? meals = HttpContext.Session.GetInt32("Meals");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            if(meals == 0)
            {
                TempData["Message"] = "You do not have any food to feed your domodachi";
            }
            else
            {
                int num = rand.Next(5,11);
                fullness += num;
                meals = meals - 1;
                HttpContext.Session.SetInt32("Fullness", (int)fullness);
                HttpContext.Session.SetInt32("Meals", (int)meals);
                TempData["Message"] = "BY THE GLORY OF THE GODS THAT WAS DELICIOUS";
            }
            return RedirectToAction("Index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            Random rand = new Random();
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int? energy = HttpContext.Session.GetInt32("Energy");
            if(energy == 0)
            {
                TempData["Message"] = "Your domodachi is too exhausted to play";
            }
            else
            {
                int num = rand.Next(5,11);
                happiness += num;
                energy = energy -5;
                HttpContext.Session.SetInt32("Happiness", (int)happiness);
                HttpContext.Session.SetInt32("Energy", (int)energy);
                TempData["Message"] = "You played with the tomadachi, it was fun";
            }
            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            Random rand = new Random();
            int? meals = HttpContext.Session.GetInt32("Meals");
            int? energy = HttpContext.Session.GetInt32("Energy");
            if(energy == 0)
            {
                TempData["Message"] = "Your domodachi is too exhausted to work";
            }
            else 
            {
                int num = rand.Next(1,4);
                meals = meals + num;
                energy = energy -5;
                HttpContext.Session.SetInt32("Energy", (int)energy);
                HttpContext.Session.SetInt32("Meals", (int)meals);
                TempData["Message"] = $"Your dojodachi worked and earned {num} meals";
            }
            return RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            energy = energy + 15;
            fullness -=5;
            happiness -=5;
            HttpContext.Session.SetInt32("Energy", (int)energy);
            HttpContext.Session.SetInt32("Fullness", (int)fullness);
            HttpContext.Session.SetInt32("Happiness", (int)happiness);
            TempData["Message"] = "Your domodachi slept and regained energy";
            return RedirectToAction("Index");
        }
    }
}
