using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class PersonaPropiedades
    {
        //Atributos
        private string nombre;
        private DateTime fechaNacimiento;
        private int edad;

        //Propiedades
        public int Edad
        {
            get //Encapsulacion de nivel abierto, por defecto es publico- acceder al valor de la propiedad
            {
                return edad;
            }

            private set //Encapsulacion de nivel abierto, para modificar el valor
            {
                edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set 
            {
                nombre = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

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
