using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public class CuentaCorriente : CuentaBancaria
    {
        public double Sobregiro { get; private set; }

        public CuentaCorriente(string titular, double sobregiro) : base(titular)
        {
            Sobregiro = sobregiro;
        }


        public override void Retirar(double cantidad)
        {
            if (cantidad <= Saldo + Sobregiro)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Retiro de {cantidad} realizado. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Cuenta Corriente:");
            base.MostrarInformacion();
            Console.WriteLine($"Sobregiro disponible: {Sobregiro}");
        }

        // Implementación del método abstracto CalcularInteresAnual
        public override void CalcularInteresAnual()
        {
            Console.WriteLine("Las cuentas corrientes no generan interés anual.");
        }
    }
}
