using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio2_Before
{
    public class Animal : IAnimal
    {
        public string Noise { get; set; }
        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }

}
