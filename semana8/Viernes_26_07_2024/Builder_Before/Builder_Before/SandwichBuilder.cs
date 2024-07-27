using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Builder_Before
{
    public abstract class SandwichBuilder
    {
        protected Sandwich _sandwich;
        public abstract void AddPan();
        public abstract void AddProteina();
        public abstract void AddQueso();
        public abstract void AddVerduras();
        public abstract void AddCondimentos();

        public Sandwich Sandwich
        {
            get { return _sandwich; } 
        }
    }
}
