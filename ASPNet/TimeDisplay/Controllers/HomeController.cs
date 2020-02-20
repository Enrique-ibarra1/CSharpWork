using System;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            Console.WriteLine(CurrentTime);
            ViewBag.Date = CurrentTime.ToString("dddd, dd MMMM yyyy hh:mm tt");

            return View();
        }
    }
}