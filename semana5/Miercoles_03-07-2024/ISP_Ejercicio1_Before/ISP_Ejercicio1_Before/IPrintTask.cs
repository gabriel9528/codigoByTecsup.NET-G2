using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_Before
{
    public interface IPrintTask
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
    }
}
