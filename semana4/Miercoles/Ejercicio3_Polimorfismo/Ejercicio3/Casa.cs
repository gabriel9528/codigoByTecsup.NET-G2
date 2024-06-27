using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Casa
    {
        //Atributos
        public string tipo;
        public double precio;
        public double areaTerreno;
        public double areaConstruida;

        public Casa()
        {
        }

        public Casa(string tipo, double precio)
        {
            this.tipo = tipo;
            this.precio = precio;
        }

        public Casa(string tipo, double precio, double areaTerreno, double areaConstruida)
        {
            this.tipo=tipo;
            this.precio = precio;
            this.areaTerreno = areaTerreno;
            this.areaConstruida = areaConstruida;
        }

        public void Vender()
        {
            Console.WriteLine(tipo + " VENDIDA por el precio de " + precio);
        }

        public void Vender(string cliente)
        {
            Console.WriteLine(tipo + " VENDIDA por el precio de " + precio + " por el cliente " + cliente);
        }

        public void Vender(double descuento)
        {
            Console.WriteLine(tipo + " VENDIDA por el precio de " + precio + " con descuento de: " + descuento);
        }

    }
}
