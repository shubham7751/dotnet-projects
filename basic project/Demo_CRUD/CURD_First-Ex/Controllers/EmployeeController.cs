using CURD_First_Ex.Data;
using CURD_First_Ex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CURD_First_Ex.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly ContextClass _cc;
        public EmployeeController(ContextClass cc)
        {
            _cc=cc;
        }
        public IActionResult Index()
        {
           //ViewData["Dept_Id"] = new SelectList(_cc.departments, "Dept_Id", "Name");

            return View(_cc.employees.ToList());
        }

        [HttpPost]
        public IActionResult Create(Employee emp) 
        {

            ViewBag.DeptId = new SelectList(_cc.departments, "Dept_Id", "Name");
            _cc.Add(emp);
            _cc.SaveChanges();
            return View("Index");

        }
    }
}
