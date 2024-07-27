using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder_Sandwich
{
    public class Sandwich
    {
        public string Pan { get; set; }
        public string Verduras { get; set; }
        public string Proteina { get; set; }
        public string Queso { get; set; }
        public string Condimentos { get; set; }

        public Sandwich()
        {
            
        }

        public Sandwich(string pan, string verduras, string proteina, string queso, string condimentos)
        {
            Pan = pan;
            Verduras = verduras;
            Proteina = proteina;
            Queso = queso;
            Condimentos = condimentos;
        }
    }
}
