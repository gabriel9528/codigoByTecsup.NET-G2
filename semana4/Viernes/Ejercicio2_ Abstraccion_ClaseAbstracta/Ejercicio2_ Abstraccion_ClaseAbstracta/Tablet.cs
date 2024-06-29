using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2__Abstraccion_ClaseAbstracta
{
    public class Tablet : Dispositivo
    {
        public Tablet(string marca, string modelo, string año) : base(marca, modelo, año)
        {
        }

        public override void Apagar()
        {
            Console.WriteLine($"Apagando la tablet {Marca} , {Modelo} y {Año}");

        }

        public override void Encender()
        {
            Console.WriteLine($"Encendiendo la tablet {Marca} , {Modelo} y {Año}");
        }

        public override void ObtenerInfo()
        {
            Console.WriteLine($"Detalles de la tablet {Marca} , {Modelo} y {Año}"); ;
        }
    }   
}
