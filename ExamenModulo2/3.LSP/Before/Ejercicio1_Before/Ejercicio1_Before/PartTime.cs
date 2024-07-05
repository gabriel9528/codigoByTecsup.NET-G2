using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before
{
    public class PartTime : Employee
    {
        public override void AssignDepartment(Department department)
        {
            throw new NotImplementedException("Soy un practicante y no necesito un departamento específico.");
        }
    }
}
