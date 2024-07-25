using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_IClonable_Before
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
