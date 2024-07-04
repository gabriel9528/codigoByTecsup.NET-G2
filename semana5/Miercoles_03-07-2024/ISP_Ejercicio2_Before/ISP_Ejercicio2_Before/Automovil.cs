using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio2_Before
{
    public class Automovil : IVehiculo
    {
        public int GetNumberOfWheel()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("Automovil en movimiento");
        }

        public string StartEngine()
        {
            return "Automovil encendido";
        }

        public string StopEngine()
        {
            return "Automovil Apagado";
        }
    }
}
