using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_PolimorfismoDinamico_ClaseAbstracta_2
{
    public class Circulo : Forma
    {
        public double Radio {  get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }
        public override double Area()
        {
            return Math.PI * Radio*Radio;
        }

        public override double Perimetro()
        {
            return 2*Math.PI*Radio;
        }
    }
}
