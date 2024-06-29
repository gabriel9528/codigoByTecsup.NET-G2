using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2__Abstraccion_ClaseAbstracta
{
    internal class TelefonoMovil : Dispositivo
    {
        public TelefonoMovil(string marca, string modelo, string año) : base(marca, modelo, año)
        {
        }

        public override void Apagar()
        {
            Console.WriteLine($"Apagando el telefono movil {Marca} , {Modelo} y {Año}");
        
        }

        public override void Encender()
        {
            Console.WriteLine($"Encendiendo el telefono movil {Marca} , {Modelo} y {Año}");
        }

        public override void ObtenerInfo()
        {
            Console.WriteLine($"Detalles del telefono movil {Marca} , {Modelo} y {Año}"); ;
        }
    }
}
