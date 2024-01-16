using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkingWhithMultipleTable.Data;
//using WorkingWhithMultipleTable.Models.View;
using WorkingWhithMultipleTable.Models.ViewModel;

namespace WorkingWhithMultipleTable.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext _context;

        public EmployeeController(ApplicationContext Context)
        {
            _context = Context;
        }

        public ApplicationContext ApplicationContext { get; }

        public IActionResult Index()
        {
            //** Merg Method To Show TwoTable Date In Single View

            //Emp_Dep emp = new Emp_Dep();
            //emp.Employees=context.Employees.ToList();
            //emp.Department=context.Departments.ToList(); 
            ////emp.Employees=empData;
            ////emp.Department=depData;
            //return View(emp);


            //**Join Method To Show TwoTable Date In Single View

            //var data = (from e in _context.Employees
            //            join d in _context.Departments
            //            on e.DepartmentId equals d.DepartmentId
            //            select new JoinTable
            //            {
            //                EmployeeId = e.EmployeeId,
            //                FirstName = e.FirstName,
            //                LastName = e.LastName,
            //                Gender = e.Gender,
            //                DepartmentCode = d.DepartmentCode,
            //                DepartmentName = d.DepartmentName,

            //            }).ToList();

            //return View(data);





            //***Direct Query Use
            Emp_Dep emp = new Emp_Dep();
            var empData = _context.Employees.FromSqlRaw("Select * from Employees").ToList();
            var depData = _context.Departments.FromSqlRaw("Select * from Departments").ToList();
            emp.Employees = empData;
            emp.Department = depData;



            return View(emp);



        }



        public IActionResult Details()
        {
            return View();
        }
    }
}
