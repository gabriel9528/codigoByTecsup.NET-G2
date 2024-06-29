using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Abstraccion
{
    public class Empleado
    {
        private string nombre;
        private int edad;
        private decimal salario;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío");
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 18 || value > 100)
                {
                    throw new ArgumentException("La edad debe estar entre 18 y 100 años");
                }
                else
                {
                    edad = value;
                }
                
            }
        }

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El salario no puede ser negativo");
                }
                else
                {
                    salario = value;
                }

            }
        }

        public static decimal CalcularSalarioAnual(decimal salarioMensual)
        {
            return salarioMensual * 12;
        }
    }
}
