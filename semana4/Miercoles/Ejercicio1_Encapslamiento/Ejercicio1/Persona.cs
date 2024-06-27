using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        //Atributos
        public string nombre;
        public DateTime fechaNacimiento;
        private int edad;

        //Metodos
        public void Registrar()
        {
            CalcularEdad(fechaNacimiento);
            Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente");
        }

        private void CalcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
    }
}
