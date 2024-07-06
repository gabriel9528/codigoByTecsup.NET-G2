using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Ejercicio1_After
{
    public interface IEmployeeSearch
    {
        int GetMaleExecutives(Gender gender, Role roel);
    }
}
