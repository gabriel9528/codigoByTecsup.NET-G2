using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Abstraccion_ClaseAbstracta
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Detener()
        {
            Console.WriteLine($"El camión {Marca}, {Modelo} se detuvo");
        }

        public override void Iniciar()
        {
            Console.WriteLine($"El camión {Marca}, {Modelo} ha iniciado su recorrido");
        }

        public override void ObtenerDetalles()
        {
            Console.WriteLine($"Camión: {Marca}, {Modelo}");
        }
    }
}
