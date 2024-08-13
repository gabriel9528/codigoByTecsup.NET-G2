using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class DataPrueba : ISingletonContainer
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["Brasilia"]= 3039444,
                ["Lima"]= 9751717
            }[name];
        }
    }
}
