using Microsoft.AspNetCore.Mvc;

namespace DotnetMVP.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
