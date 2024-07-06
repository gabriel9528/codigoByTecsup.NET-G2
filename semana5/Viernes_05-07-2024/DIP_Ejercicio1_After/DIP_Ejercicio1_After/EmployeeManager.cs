using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Ejercicio1_After
{
    public class EmployeeManager : IEmployeeSearch
    {
        private readonly List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees => _employees;

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }
        public int GetMaleExecutives(Gender gender, Role roel)
        {
            return _employees.Where(x => x.Gender == Gender.Male && x.Role == Role.Executive).Count();
        }
    }
}
