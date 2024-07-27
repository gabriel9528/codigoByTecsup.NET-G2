using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Before
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public SandwichAssembly(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void Assemblly()
        {
            _sandwichBuilder.AddPan();
            _sandwichBuilder.AddProteina();
            _sandwichBuilder.AddQueso();
            _sandwichBuilder.AddVerduras();
            _sandwichBuilder.AddCondimentos();
        }

        public Sandwich GetSandwich
        {
            get { return _sandwichBuilder.Sandwich;  }
        }
    }
}
