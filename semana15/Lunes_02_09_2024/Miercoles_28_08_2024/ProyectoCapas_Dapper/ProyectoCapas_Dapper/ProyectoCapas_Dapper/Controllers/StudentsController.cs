using BLL.LogicServices;
using BOL.CommonEntities;
using BOL.DataBaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoCapas_Dapper.Controllers
{
    [Route("Students1")]
    public class StudentsController : Controller
    {
        private readonly IStudentLogic _studentLogic;

        public StudentsController(IStudentLogic studentLogic)
        {
            _studentLogic = studentLogic;
        }

        [HttpGet("getStudents")]
        public IActionResult StudentList()
        {
            StudentModel studentModel = new StudentModel();
            studentModel.StudentList = _studentLogic.GetStudentListLogic();
            return View(studentModel);
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudentPost(Student student)
        {
            string result = _studentLogic.SaveStudentLogic(student);
            if(result == "Estudiante guardado exitosamente")
            {
                return RedirectToAction(nameof(StudentList));
            }
            else 
            {
                TempData["ErrorTemp"] = result;
                return RedirectToAction(nameof(CreateStudent));
            }
        }

        [HttpGet("EditStudent/{StudentId}")]
        public IActionResult EditStudent2(int StudentId)
        {
            var student = _studentLogic.GetStudentListLogic().FirstOrDefault(x => x.StudentId == StudentId);
            if(student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost("EditStudent")]
        public IActionResult EditStudentPost(Student student)
        {
            string result = _studentLogic.UpdateStudentLogic(student);
            if (result == "Estudiante actualizado exitosamente")
            {
                return RedirectToAction(nameof(StudentList));
            }
            else
            {
                TempData["ErrorTemp"] = result;
                return RedirectToAction(nameof(EditStudent2), new {id = student.StudentId });
            }
        }

        [HttpGet("DeleteStudent/{StudentId}")]
        public IActionResult GetDeleteStudent(int StudentId)
        {
            var student = _studentLogic.GetStudentListLogic().FirstOrDefault(x => x.StudentId == StudentId);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost("DeleteStudent")]
        public IActionResult DeleteStudent(int StudentId)
        {
            string result = _studentLogic.DeleteStudentLogic(StudentId);
            if (result == "Estudiante eliminado exitosamente")
            {
                return RedirectToAction(nameof(StudentList));
            }
            else
            {
                TempData["ErrorTemp"] = result;
                return RedirectToAction(nameof(GetDeleteStudent), new { id = StudentId });
            }
        }
    }
}
