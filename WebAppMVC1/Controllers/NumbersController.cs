using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC1.Controllers
{
    public class NumbersController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 10); //created an enumerable table which ranged from 1 to 10

            return View(numbers); // in return the View will give us the numbers list that cannot be changed since it is enumerable
        }
    }
}
