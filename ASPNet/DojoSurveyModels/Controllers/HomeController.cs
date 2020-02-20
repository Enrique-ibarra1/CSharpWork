using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModels.Models;

namespace DojoSurveyModels.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult CompleteSurvey(Survey yoursurvey)
        {
            if(ModelState.IsValid)
            {
                Survey newSurvey = yoursurvey;
                return View("result", newSurvey);
            }
            else{
                return View("index");
            }

        }
    }
}
