using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio_After
{
    public class HPLaserJetPrinter : IFax, IPrint, IScan
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
