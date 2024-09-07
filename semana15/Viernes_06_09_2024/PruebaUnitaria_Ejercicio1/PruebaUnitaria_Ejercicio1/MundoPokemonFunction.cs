using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitaria_Ejercicio1
{
    public class MundoPokemonFunction
    {
        public string ReturnsPikachu(int num)
        {
            if (num == 0)
                return "PIKACHU";
            else
                return "SQUAURTLE";
        }
    }
}
