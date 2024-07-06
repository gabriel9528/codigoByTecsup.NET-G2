using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Ejercicio1_After
{
    public class EmploySearch
    {
        private readonly IEmployeeSearch _employeeSearch;

        public EmploySearch(IEmployeeSearch employeeSearch)
        {
            _employeeSearch = employeeSearch;
        }
        public int GetMaleExecutives(Gender gender, Role role)
        {
            return _employeeSearch.GetMaleExecutives(gender, role);
        }
    }
}
