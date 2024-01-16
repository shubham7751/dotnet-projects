using ClassLibrary2.dboperation;
using Microsoft.AspNetCore.Mvc;
using WebApplication2_Entity2.db.dboperation;
using WebApplication2_Entity2.model.emp;

namespace WebApplication2_Entity2.Controllers
{
    public class HomeController : Controller
    {
        emprepo repo = null;
        public HomeController() {

            emprepo = new emprepo();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(emp  emp1)
        {
            return View();
        }
    }
}
