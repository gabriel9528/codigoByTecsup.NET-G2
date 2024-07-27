using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class SaludoBuilder
    {
        private readonly Saludo _saludo;

        public SaludoBuilder()
        {
            _saludo = new Saludo();
        }

        public SaludoBuilder HoraDelDia(string horaDelDia)
        {
            _saludo.HoraDelDia = horaDelDia;
            return this;
        }

        public SaludoBuilder SaludarA(string saludarA)
        {
            _saludo.SaludarA = saludarA;
            return this;
        }

        public Saludo Build()
        {
            return _saludo;
        }
    }
}
