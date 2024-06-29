using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public abstract class CuentaBancaria : ICuentaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public CuentaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        // Métodos de la interfaz ICuentaBancaria, se usa Virtual para sobreescribir el metodo de Retirar y
        // MostrarInformacion en las cuentas corrientes, cuentas de ahorro de ahorro y cuentas de inversion,
        // mas no en el metodo Depositar
        public void Depositar(double cantidad)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depósito de {cantidad} realizado. Nuevo saldo: {Saldo}");
        }

        public virtual void Retirar(double cantidad)
        {
            if (cantidad <= Saldo)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Retiro de {cantidad} realizado. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        // Método abstracto para calcular interés mensual
        public abstract void CalcularInteresAnual();
    }
}
