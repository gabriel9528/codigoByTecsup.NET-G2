using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class SingletonFinder
    {
        private ISingletonContainer _container;

        public SingletonFinder(ISingletonContainer container)
        {
            _container = container;
        }
        public int GetTotalPopultaion(IEnumerable<string> listaCapitales)
        {
            int total = 0;
            foreach(var poblacion in listaCapitales)
            {
                total += SingletonContainer.Instance.GetPopulation(poblacion);
            }
            return total;
        }
    }
}
