using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio2_Before
{
    public class Bicicleta : IVehiculo
    {
        public int GetNumberOfWheel()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("Bicicleta en movimiento");
        }

        public string StartEngine()
        {
            throw new NotImplementedException("Bicicleta no tiene motor");
        }

        public string StopEngine()
        {
            throw new NotImplementedException("Bicicleta no tiene motor");
        }
    }
}
