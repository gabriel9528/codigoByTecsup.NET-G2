using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitaria_Ejercicio1.Test
{
    public static class MundoPokemonFunctionTest
    {
        public static void MundoPokemonFunction_ReturnsPikachu()
        {
            //arrange
            int num = 0;
            MundoPokemonFunction mundoPokemonFunction = new MundoPokemonFunction();

            //act-execute
            string result = mundoPokemonFunction.ReturnsPikachu(num);

            //assert
            if(result == "PIKACHU")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }
    }
}
