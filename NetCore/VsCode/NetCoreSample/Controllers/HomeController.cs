using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Models;
namespace NetCoreSample.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index(){
            return View(Person.person.ToList());
        }

        public ActionResult AddPerson(){
        return View();
        }

        [HttpPost]
        public ActionResult AddPerson(Person person){
            var personMax=Person.person.Max(x=>x.PersonID);
            personMax++;
            person.PersonID=personMax;
            Person.person.Add(person);
        return View();
        }
    }
}