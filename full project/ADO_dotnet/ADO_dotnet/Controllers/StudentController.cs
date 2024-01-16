using ADO_dotnet.Models;
using ADO_dotnet.Services;
using Microsoft.AspNetCore.Mvc;

namespace ADO_dotnet.Controllers
{
    public class StudentController : Controller
    {
       
        
        private readonly IStudentService _StudentService;

        public StudentController(IStudentService studentService) 
        {
            _StudentService = studentService;
        }


        [HttpGet]
        public IActionResult StudentList()
        {
            AllModels model = new AllModels();
          //  List<Student> studentsList = new List<Student>();
           
     model.studentlist = _StudentService.GetStudentsRecords().ToList();
   
            return View(model);
        }
    }
}
