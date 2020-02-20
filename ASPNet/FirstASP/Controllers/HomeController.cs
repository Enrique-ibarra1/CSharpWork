using Microsoft.AspNetCore.Mvc;
namespace FirstASP.Controllers
{
    public class HomeController : Controller
    {
        //for each route this controller is to handle:
        //localhost:5000/
        //associated route. empty string is the base route
        [HttpGet("")]// type of request
        public string Index()//action
        {
            return "Hello from controller";
        }

        //localhost:5000/hello
        //associated string route 
        [HttpGet("hello")]// type of request
        public string Hello()//action
        {
            return "Hi again";
        }

        [HttpGet("users/{location}/{username}")]
        public string UserProfile(string username, string location)
        {
            if(location == "Chicago")
            {
                return$"Hello {username} from {location}. Its cold";
            }
            return $"Hello {username} from {location}   ";
        }
    }

}