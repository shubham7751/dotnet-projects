using Crud_3.Data;
using Crud_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Crud_3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;

        public EmployeeController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create() 
        {
                return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model) {
        
            if (ModelState.IsValid)
            {
                var emp = new Employee() 
                {
                  Name = model.Name,
                  City = model.City,
                  State = model.State,
                  Salary = model.Salary,
                };
                context.Employees.Add(emp);
                context.SaveChanges();
                TempData["success"] = "Created Successfully";

                return RedirectToAction("Index");
               
            }
            else
            {
                TempData["error"] = "empty fiel can't Submit";
                 return View(model);
            }
        }
        public IActionResult Delete(int id) 
        {
           var emp=context.Employees.SingleOrDefault(e => e.Id == id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            TempData["success"] = "Deleted";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var emp=context.Employees.SingleOrDefault(e=>e.Id==id);
            var result = new Employee()
            {  
                Name = emp.Name,
                City = emp.City,
                State = emp.State, 
                Salary = emp.Salary,
            };
            return View(result); 
        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            var emp = new Employee()
            {
                Id=model.Id,    
                Name = model.Name,
                City = model.City,
                State = model.State,
                Salary = model.Salary,

            };
            context.Employees.Update(emp);
            context.SaveChanges(true);
            TempData["success"] = "Value Successfully Updated";
            return RedirectToAction("Index");
           
        }
    }
}




//********************************************************************************************************8

//using Curdcore7._0.Data;
//using Curdcore7._0.Model;
//using Microsoft.AspNetCore;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;

//namespace Curdcore7._0.Controllers
//{
//    public class StudentsSSController : Controller
//    {
//        private readonly ComponyContext _context;

//        public StudentsSSController(ComponyContext context)
//        {
//            _context = context;
//        }

//        // GET: StudentsSS
//        public IActionResult Index(string searchString)
//        {
//            ViewData["CurrentFilter"] = searchString;

//            var Stud = from mem in _context.students
//                       select mem;
//            if (!String.IsNullOrEmpty(searchString))
//            {
//                Stud = Stud.Where(m => m.Name.Contains(searchString)
//                                       || m.Adress.Contains(searchString)
//                                        || m.Class.Contains(searchString)
//                                         || m.Skills.SkillName.StartsWith(searchString));
//                return View(Stud);
//            }

//            var stdList = _context.students.ToList();
//            return View(stdList);

//        }
//        //public IActionResult Index()
//        //{
//        //    var componyContext = _context.students.Include(s => s.Skills);
//        //    return View(componyContext.ToList());
//        //}

//        // GET: StudentsSS/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || _context.students == null)
//            {
//                return NotFound();
//            }

//            var student = await _context.students
//                .Include(s => s.Skills)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (student == null)
//            {
//                return NotFound();
//            }

//            return View(student);
//        }

//        // GET: StudentsSS/Create

//        public IActionResult Create()
//        {
//            ViewBag.SkillId = new SelectList(_context.skills, "SkillId", "SkillName");
//            return View();
//        }

//        // POST: StudentsSS/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        public IActionResult Create(Student student)
//        {
//            ViewBag.SkillId = new SelectList(_context.skills, "SkillId", "SkillName");

//            _context.Add(student);
//            _context.SaveChangesAsync();
//            TempData["success"] = "Value successfully inserted !";
//            return RedirectToAction("Index");

//        }

//        // GET: StudentsSS/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.students == null)
//            {
//                return NotFound();
//            }

//            var student = await _context.students.FindAsync(id);
//            if (student == null)
//            {
//                return NotFound();
//            }
//            ViewBag.SkillId = new SelectList(_context.skills, "SkillId", "SkillName");
//            return View(student);
//        }

//        // POST: StudentsSS/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Adress,Age,Class,SkillId")] Student student)
//        {
//            if (id != student.Id)
//            {
//                return NotFound();
//            }


//            try
//            {
//                _context.Update(student);
//                await _context.SaveChangesAsync();
//                TempData["success"] = "Value successfully updated !";
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!StudentExists(student.Id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }

//            }
//            ViewBag.SkillId = new SelectList(_context.skills, "SkillId", "SkillName");
//            return RedirectToAction("Index");
//        }

//        // GET: StudentsSS/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.students == null)
//            {
//                return NotFound();
//            }

//            var student = await _context.students
//                .Include(s => s.Skills)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (student == null)
//            {
//                return NotFound();
//            }

//            return View(student);
//        }

//        // POST: StudentsSS/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.students == null)
//            {
//                return Problem("Entity set 'ComponyContext.students'  is null.");
//            }
//            var student = await _context.students.FindAsync(id);
//            if (student != null)
//            {
//                _context.students.Remove(student);
//            }
//            await _context.SaveChangesAsync();
//            TempData["success"] = "Record Deleted!";

//            return RedirectToAction(nameof(Index));
//        }

//        private bool StudentExists(int id)
//        {
//            return (_context.students?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
