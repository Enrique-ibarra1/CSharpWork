using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Chef> ChefsRoster = dbContext.Chefs.Include(c => c.CreatedDishes).ToList();
            return View(ChefsRoster);
        }

        [HttpGet("newchef")]
        public IActionResult NewChef()
        {
            return View("newchef");
        }

        [HttpPost("addchef")]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("newchef");
            }
        }
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> Menu = dbContext.Dishes.Include(d => d.Creator).ToList();
            return View("dishes", Menu);
        }
        [HttpGet("newdish")]
        public IActionResult NewDish()
        {
            List<Chef> Chefs = dbContext.Chefs.ToList();
            ViewBag.ChefRoster = Chefs;
            return View("newdish");
        }
        [HttpPost("adddish")]
        public IActionResult AddDish(Dish newDish)
        {
            dbContext.Dishes.Add(newDish);
            dbContext.SaveChanges();
            return RedirectToAction("Dishes");
        }

    }
}
