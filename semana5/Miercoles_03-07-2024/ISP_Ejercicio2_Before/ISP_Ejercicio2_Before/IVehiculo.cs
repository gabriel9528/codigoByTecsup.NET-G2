using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio2_Before
{
    public interface IVehiculo
    {
        void Move();
        int GetNumberOfWheel();
        string StartEngine();
        string StopEngine();
    }
}
