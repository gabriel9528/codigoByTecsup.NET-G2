using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_IClonable_Before
{
    public class Producto
    {
        public Producto(string name, Category category)
        {
            Name = name;
            Category = category;
        }
        public string Name { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}, Persona: {Category.Person.Name}";
        }

    }
}
