using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Before
{
    public class CheeseBurger : SandwichBuilder
    {
        public CheeseBurger()
        {
            _sandwich = new Sandwich();
        }
        public override void AddCondimentos()
        {
            _sandwich.Condimentos = "mayonesa";
        }

        public override void AddPan()
        {
            _sandwich.Pan = "pan de molde";
        }

        public override void AddProteina()
        {
            _sandwich.Proteina = "proteina A";
        }

        public override void AddQueso()
        {
            _sandwich.Queso = "queso cheddar";
        }

        public override void AddVerduras()
        {
            _sandwich.Verduras = "tomates, lechuga";
        }
    }
}
