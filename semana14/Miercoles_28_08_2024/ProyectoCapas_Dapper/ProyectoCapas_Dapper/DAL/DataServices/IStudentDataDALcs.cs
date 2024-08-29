using BOL.DataBaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataServices
{
    public interface IStudentDataDALcs
    {
        List<Student> GetStudentListData();
        string SaveStudentData(Student student);
    }
}
