using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas
{
    public class Venta
    {
        private string _producto;
        private int _cantidad;

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public double AsignarPrecio()
        {
            switch (Producto)
            {
                case "Celular" : return 1500;
                case "Laptop" : return 3000;
                case "Monitor" : return 500;
                case "Televisor" : return 1800;
                case "Lavadora" : return 2000;
            }
            return 0;
        }

        //Calcular SubTotal
        public double CalcularSubTotal()
        {
            return AsignarPrecio() * Cantidad;
        }

        public double CalcularDescuento()
        {
            double subTotal = CalcularSubTotal();

            if(subTotal <= 2000)
            {
                return subTotal * 0.05;
            }
            else if(subTotal > 2000 && subTotal<= 5000)
            {
                return subTotal * 0.1;
            }
            else
            {
                return subTotal * 0.20;
            }
        }

        public double CalcularNeto()
        {
            return CalcularSubTotal() - CalcularDescuento();
        }



    }
}
