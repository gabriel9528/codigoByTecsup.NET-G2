using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_IClonable_Before
{
    public class Producto : IPrototype<Producto>
    {
        public Producto(string name, Category category)
        {
            Name = name;
            Category = category;
        }
        public string Name { get; set; }
        public Category Category { get; set; }

        public Producto DeepCopy()
        {
            return new Producto(Name, Category.DeepCopy());
        }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}";
        }

    }
}
