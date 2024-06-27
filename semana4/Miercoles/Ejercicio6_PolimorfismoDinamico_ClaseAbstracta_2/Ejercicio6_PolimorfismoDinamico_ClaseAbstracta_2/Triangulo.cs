using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_PolimorfismoDinamico_ClaseAbstracta_2
{
    public class Triangulo : Forma
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Triangulo(int baseTriangulo, int altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }
        public override double Area()
        {
            return 0.5* Altura*Base;
        }

        public override double Perimetro()
        {
            //Suponer
            return Base + Altura;
        }
    }
}
