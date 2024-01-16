using Microsoft.AspNetCore.Mvc;
using WebApplication2_My4.Models;
namespace WebApplication2_My4.Controllers
{
    public class HomeController : Controller
    {
        private readonly Employee _employee;
       

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(Employee emp) 

        { 

            if(ModelState.IsValid)
            {
                return View();
            }
           return View("Index");

        }
    }
}
