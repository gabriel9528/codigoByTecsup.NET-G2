using BOL.DataBaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonEntities
{
    public class StudentModel
    {
        public List<Student>? StudentList { get; set; }
        public List<Course>? CoursetList { get; set; }
    }
}
