using BLL.LogicServices;
using BOL.CommonEntities;
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
    }
}
