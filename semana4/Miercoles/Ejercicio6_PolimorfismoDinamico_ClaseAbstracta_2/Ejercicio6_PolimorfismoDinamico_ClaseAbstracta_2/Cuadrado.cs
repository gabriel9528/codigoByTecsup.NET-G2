using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_PolimorfismoDinamico_ClaseAbstracta_2
{
    public class Cuadrado : Forma
    {
        public int Lado { get; set; }

        public Cuadrado(int lado)
        {
            Lado = lado;
        }
        public override double Area()
        {
            return Lado*Lado;
        }

        public override double Perimetro()
        {
            return 4 * Lado;
        }
    }
}
