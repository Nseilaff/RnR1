using Microsoft.AspNetCore.Mvc;
using RnR1.Models;

namespace RnR1.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository repo;
        public PersonController(IPersonRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetAllPerson());
        }
        public IActionResult ViewPerson(int id)
        {
            var person = repo.GetPerson(id);
            return View(person);
        }
        public IActionResult UpdatePerson(int id)
        {
            Person per = repo.GetPerson(id);
            if (per == null)
            {
                return View("Person Not Found");
            }
            return View(per);
        }
        public IActionResult UpdatePersonToDatabase(Person person)
        {
            repo.UpdatePerson(person);
            return RedirectToAction("ViewPerson", new {id = person.PersonID});
        }
        public IActionResult InsertPerson()
        {
            var person = new Person();
            return View(person);
        }

        public IActionResult InsertPersonToDatabase(Person personToInsert)
        {
            repo.InsertPerson(personToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePerson(Person person)
        {
            repo.DeletePerson(person);
            return RedirectToAction("Index");
        }

        public IActionResult SelectTime(Person person)
        {
            person = repo.GetTimeSlots(person);
            return View(person);
        }

        //public IActionResult UpdateTime(Person person)
        //{
        //    person = repo.GetTimeSlots(person);
        //    return View(person);

        //}
    }
}
