using Microsoft.AspNetCore.Mvc;

namespace SuperMarket_Management_System.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
