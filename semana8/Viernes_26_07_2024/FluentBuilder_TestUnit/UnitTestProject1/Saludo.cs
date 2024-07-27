using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Saludo
    {
        public string HoraDelDia { get; set; }
        public string SaludarA { get; set; }
        public string Message => $"Buenas {HoraDelDia}, {SaludarA}";
    }
}
