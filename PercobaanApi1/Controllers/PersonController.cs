using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;

namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }

        [HttpGet("api/person/{Id}")]
        public ActionResult<Person> GetDataById(int Id)
        {
            PersonContext context = new PersonContext();
            Person Person = context.GetDataById(Id);
            return Ok(Person);
        }

    }
}
