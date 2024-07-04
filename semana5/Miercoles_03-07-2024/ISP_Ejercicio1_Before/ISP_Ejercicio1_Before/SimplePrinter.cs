using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_Before
{
    public class SimplePrinter : IPrintTask
    {
        public void Fax(string content)
        {
            throw new NotImplementedException("No puedo realizar el FAX, porque soy una impresora simple");
        }

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
