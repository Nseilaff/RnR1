using Microsoft.AspNetCore.Mvc;

namespace RnR1.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepo repo;
        public EventController(IEventRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetAllEvents());
        }
    }
}
