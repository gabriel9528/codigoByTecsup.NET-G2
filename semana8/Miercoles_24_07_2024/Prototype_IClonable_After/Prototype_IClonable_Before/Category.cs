using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_IClonable_Before    
{
    public class Category : ICloneable
    {
        public string Name { get; set; }    
        public Category(string name)
        {
            Name = name;
        }

        public object Clone()
        {
            return new Category(Name);
        }
    }
}
