using Microsoft.AspNetCore.Mvc;

namespace RnR1.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
