using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder_Sandwich
{
    public class SandwichBuilder
    {

        protected Sandwich _sandwich = new Sandwich();

        public Sandwich Sandwich => _sandwich;

        public SandwichBuilder AddProteina()
        {
            _sandwich.Proteina = "Proteina de carne";
            return this;
        }

        public SandwichBuilder AddQueso()
        {
            _sandwich.Queso = "Queso cheddar";
            return this;
        }

        public SandwichBuilder AddCondimentos()
        {
            _sandwich.Condimentos = "Mayonesa";
            return this;
        }

        public SandwichBuilder AddPan()
        {
            _sandwich.Pan = "Pan de trigo";
            return this;
        }

        public SandwichBuilder AddVerduras()
        {
            _sandwich.Verduras = "Lechuga";
            return this;
        }
    }
}
