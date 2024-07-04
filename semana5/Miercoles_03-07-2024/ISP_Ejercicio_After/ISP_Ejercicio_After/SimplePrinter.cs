using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio_After
{
    public class SimplePrinter : IPrint, IScan
    {
        public void Print(string content)
        {
            Console.WriteLine($"SimplePrinter-Print: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"SimplePrinter-Scan: {content}");
        }
    }
}
