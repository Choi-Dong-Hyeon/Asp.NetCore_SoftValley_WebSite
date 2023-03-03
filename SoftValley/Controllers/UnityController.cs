using Microsoft.AspNetCore.Mvc;

namespace SoftValley.Controllers
{
    public class UnityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
