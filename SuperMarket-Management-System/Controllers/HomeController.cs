using Microsoft.AspNetCore.Mvc;

namespace SuperMarket_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello world from action method.";
        }

        public string Error()
        {
            return "I have an error here";
        }
    }
}
