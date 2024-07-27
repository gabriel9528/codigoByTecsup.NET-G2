using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder_TestUnit
{
    public class Saludo
    {
        public string HoraDelDia { get; set; }
        public string SaludarA { get; set; }
        public string Message => $"Buenos {HoraDelDia}, {SaludarA}";
    }
}
