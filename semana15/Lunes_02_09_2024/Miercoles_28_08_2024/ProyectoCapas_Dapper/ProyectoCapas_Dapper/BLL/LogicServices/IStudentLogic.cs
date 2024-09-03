using BOL.DataBaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LogicServices
{
    public interface IStudentLogic
    {
        List<Student> GetStudentListLogic();
        string SaveStudentLogic(Student student);
        string UpdateStudentLogic(Student student);
        string DeleteStudentLogic(int studentId);
    }
}
