using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_ColeccionDatos
{
    public class Universidad
    {
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public string Direccion { get; set; }

        public Universidad(string nombre, string acronimo, string direccion )
        {
            Acronimo = acronimo;
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
