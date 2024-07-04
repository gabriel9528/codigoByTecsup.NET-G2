using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_Before
{
    public class HPLaserJetPrinter : IPrintTask
    {
        public void Fax(string content)
        {
            Console.WriteLine($"HPLaserJetPrinter-Fax: {content}");
        }

        public void Print(string content)
        {
            Console.WriteLine($"HPLaserJetPrinter-Print: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"HPLaserJetPrinter-Scan: {content}");
        }
    }
}
