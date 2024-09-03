using BOL.DataBaseEntities;
using DAL.DataContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataServices
{
    public class StudentDataDALcs : IStudentDataDALcs
    {
        private readonly IDapperConnectionHelper _dapperConnectionHelper;

        public StudentDataDALcs(IDapperConnectionHelper dapperConnectionHelper)
        {
            _dapperConnectionHelper = dapperConnectionHelper;
        }

        public List<Student> GetStudentListData()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                using (IDbConnection dbConnection = _dapperConnectionHelper.GetDapperContextHelper())
                {
                    string query = "SELECT * FROM Student";
                    studentList = dbConnection.Query<Student>(query, commandType: CommandType.Text).ToList();
                }
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
            return studentList;
        }

        public string SaveStudentData(Student student)
        {
            string result = "";
            try
            {
                using (IDbConnection dbConnection = _dapperConnectionHelper.GetDapperContextHelper())
                {
                    string query = "Insert into Student (FirstName, LastName, Email) values (@FirstName, @LastName, @Email)";
                    dbConnection.Execute(query, new
                    {
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        Email = student.Email
                    }, commandType: CommandType.Text);

                    result = "Estudiante guardado exitosamente";

                }
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }

            return result;
        }
    }
}
