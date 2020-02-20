using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string newMessage = "I saw Kanye at a grocery store in Los Angeles a while ago. I told him how cool it was to meet him in person, but I didn’t want to be a jerk and bother him and ask him for photos or anything. He said, 'Oh, like you’re doing now?' I was taken aback, and all I could say was 'Huh?' but he kept cutting me off and going 'huh? huh? huh?' and closing his hand shut in front of my face. I walked away and continued with my shopping, and I heard him chuckle as I walked off. When I came to pay for my stuff up front I saw him trying to walk out the doors with like 30 Milky Ways in his hands without paying. The girl at the counter was very nice about it and professional, and was like 'Sir, you need to pay for those first.' At first he kept pretending to be tired and not hear her, but eventually turned back around and brought them to the counter. When she took one of the bars and started scanning it multiple times, he stopped her and told her to scan them each individually 'to prevent any electrical interfierance,' and then turned around and winked at me. I don’t even think that’s a word. After she scanned each bar and put them in a bag and started to say the price, he kept interrupting her by yawning really loudly.";
            return View("Index", newMessage);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] intArray = new int[6]{1,2,3,4,5,6};
            return View(intArray);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User UserOne = new User()
            {
                FirstName = "Timmy",
                LastName = "Tommy"
            };
            User UserTwo = new User()
            {
                FirstName = "Jimmy",
                LastName = "Jommy"
            };
            User UserThree = new User()
            {
                FirstName = "Cow",
                LastName = "Man"
            };
            List<User> UserList = new List<User>()
            {
                UserOne, UserThree, UserTwo
            };
            return View(UserList);
        }

        [HttpGet("user")]
        public IActionResult UserProfile()
        {
            User Jimmy = new User()
            {
                FirstName = "Jimmy",
                LastName = "Ahoy"
            };
            return View("user", Jimmy);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
