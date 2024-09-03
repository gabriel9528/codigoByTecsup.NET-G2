using BOL.DataBaseEntities;
using DAL.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LogicServices
{
    public class StudentLogic: IStudentLogic
    {
        private readonly IStudentDataDAL _studentDataDALcs;

        public StudentLogic(IStudentDataDAL studentDataDALcs)
        {
            _studentDataDALcs = studentDataDALcs;
        }

        public List<Student> GetStudentListLogic()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                studentList = _studentDataDALcs.GetStudentListData();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            return studentList;
        }

        public string SaveStudentLogic(Student student)
        {
            string result = "";
            try
            {
                if(String.IsNullOrEmpty(student.FirstName) || 
                    String.IsNullOrEmpty(student.LastName) ||
                    String.IsNullOrEmpty(student.Email))
                {
                    result = "Por favor, complete todos los campos";
                }

                result = _studentDataDALcs.SaveStudentData(student);
                if (result == "Estudiante guardado exitosamente")
                {
                    return result;
                }
                else
                {
                    return result = "Error al guardar el estudiante";;
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string UpdateStudentLogic(Student student)
        {
            string result = "";
            try
            {
                if( student.StudentId <= 0 ||
                    String.IsNullOrEmpty(student.FirstName) ||
                    String.IsNullOrEmpty(student.LastName) ||
                    String.IsNullOrEmpty(student.Email))
                {
                    return result = "Por favor, complete todos los campos";
                }

                result = _studentDataDALcs.UpdateStudentData(student);
                return result == "Estudiante actualizado exitosamente" ? result : "Error al actualizar el estudiante";

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string DeleteStudentLogic(int studentId)
        {
            string result = "";
            if (studentId <= 0)
            {
                return "Id de estudiante no válido";
            }

            result = _studentDataDALcs.DeleteStudentData(studentId);
            return result == "Estudiante eliminado exitosamente" ? result : "Error al eliminar el estudiante";

        }
    }
}
