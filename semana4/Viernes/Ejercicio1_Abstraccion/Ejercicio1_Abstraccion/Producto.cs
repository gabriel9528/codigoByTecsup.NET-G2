using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Abstraccion
{
    public class Producto
    {
        private static int contadorIds = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, decimal precio, int stock)
        {
            Id = contadorIds++;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            
        }
        public static decimal CalcularTotalVentas(List<Producto> productosVendidos)
        {
            decimal totalVentas = 0;
            foreach(Producto i in productosVendidos)
            {
                totalVentas += i.Precio * i.Stock;
            }
            return totalVentas;
        }

        public void RestarStock(int cantidadVendida)
        {
            if(cantidadVendida <= Stock)
            {
                //Stock = Stock - cantidadVendida;
                Stock -= cantidadVendida;
            }
            else
            {
                Console.WriteLine("No hay suficiente stock para realizar la venta");
            }
        }

    }
}
