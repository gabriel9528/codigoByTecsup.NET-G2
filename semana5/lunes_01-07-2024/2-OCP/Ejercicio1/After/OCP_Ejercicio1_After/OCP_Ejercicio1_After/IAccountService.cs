using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ejercicio1_After
{
    public interface IAccountService
    {
        Staff Create(IPerson Iperson);
    }
}
