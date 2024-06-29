using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Abstraccion_ClaseAbstracta
{
    public class Motocicleta : Vehiculo
    {
        public int Año { get; set; }
        public Motocicleta(string marca, string modelo, int año) : base(marca, modelo)
        {
            Año = año;
        }

        public override void Detener()
        {
            Console.WriteLine($"La motocicleta {Marca}, {Modelo} se detuvo");
        }

        public override void Iniciar()
        {
            Console.WriteLine($"La motocicleta {Marca}, {Modelo} ha iniciado su recorrido");
        }

        public override void ObtenerDetalles()
        {
            Console.WriteLine($"Motocicleta: {Marca}, {Modelo}, {Año}");
        }
    }
}
