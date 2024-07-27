using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Before
{
    public class Sandwich
    {
        public string Pan { get; set; }
        public string Verduras { get; set; }
        public string Proteina { get; set; }
        public string Condimentos { get; set; }
        public string Queso { get; set; }

        public Sandwich()
        {
            
        }

        public Sandwich(string pan, string verduras, string proteina, string condimentos, string queso)
        {
            Pan = pan;
            Verduras = verduras;
            Proteina = proteina;
            Condimentos = condimentos;
            Queso = queso;
        }

    }
}
