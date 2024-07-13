using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding2
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Estudiante(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
