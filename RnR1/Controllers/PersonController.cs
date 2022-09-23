using Microsoft.AspNetCore.Mvc;

namespace RnR1.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository repo;
        public PersonController(IPersonRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult VeiwPerson(int id)
        {
            var person = repo.GetPerson(id);
            return View(person);
        }
    }
}
