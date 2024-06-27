using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_PolimorfismoDinamico_ClaseAbstracta
{
    public class Alumno : Persona
    {
        public Alumno(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public override string Saludar()
        {
            string saludo = "Hola, mi nombre es: " + this.Nombre + " y soy alumno";
            return saludo;
        }
    }
}
