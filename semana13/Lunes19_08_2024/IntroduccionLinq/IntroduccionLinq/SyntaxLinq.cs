using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    public class SyntaxLinq
    {
        public static void Main(string[] args)
        {
            //*--------------------Syntax Query---------------------*
            Console.WriteLine("Syntax Query");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var querySyntax = from x in numbers
                              where x > 6
                              select x;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }


            //*--------------------Syntax Method---------------------*
            Console.WriteLine("Syntax Method");
            var methodQuery = numbers.Where(obj => obj > 6);

            foreach(var item in methodQuery)
            {
                Console.WriteLine(item);
            }

            //*--------------------Syntax Mixed---------------------*
            Console.WriteLine("Syntax Mixed");
            var methodMixed = (from i in numbers
                               where i > 2
                               select i).Sum();

            Console.WriteLine("La suma de los numeros mayores a 2 es:" + methodMixed);

        }
    }
}
