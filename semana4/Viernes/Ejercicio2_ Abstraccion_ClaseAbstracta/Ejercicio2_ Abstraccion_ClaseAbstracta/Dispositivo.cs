using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2__Abstraccion_ClaseAbstracta
{
    public abstract class Dispositivo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }

        public Dispositivo(string marca, string modelo, string año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void ObtenerInfo();

    }
}
