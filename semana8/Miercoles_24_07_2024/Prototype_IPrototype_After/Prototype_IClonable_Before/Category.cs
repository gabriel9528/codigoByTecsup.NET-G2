using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_IClonable_Before    
{
    public class Category 
    {
        public Person Person { get; set; }
        public string Name { get; set; }    
        public Category(string name, Person person)
        {
            Name = name;
            Person = person;
        }
    }
}
