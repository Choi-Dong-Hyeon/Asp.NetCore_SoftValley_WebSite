using Microsoft.AspNetCore.Mvc;

namespace SoftValley.Controllers
{
    public class AspController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
