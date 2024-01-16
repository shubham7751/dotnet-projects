using Crud_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crud_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}





//// ***************************************************************************************************************8

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

// POST: StudentsSS/Create
// To protect from overposting attacks, enable the specific properties you want to bind to.
// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//public IActionResult Create(Student student)
//{
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





//*************************************************************************************************************************************************************
