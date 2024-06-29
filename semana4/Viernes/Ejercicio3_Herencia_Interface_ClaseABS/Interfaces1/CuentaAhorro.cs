using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public class CuentaAhorro : CuentaBancaria, IInteresGenerable
    {
        public double TasaInteres { get; private set; }

        public CuentaAhorro(string titular, double tasaInteres) : base(titular)
        {
            TasaInteres = tasaInteres;
        }

        // Implementación del método CalcularInteresMensual
        public void CalcularInteresMensual()
        {
            double interesMensual = Saldo * TasaInteres / 100 / 12;
            Saldo += interesMensual;
            Console.WriteLine($"Interés mensual generado: {interesMensual}. Nuevo saldo: {Saldo}");
        }


        // Método para mostrar información de la cuenta de ahorro
        public override void MostrarInformacion()
        {
            Console.WriteLine("Cuenta de Ahorro:");
            base.MostrarInformacion();
        }

        // Implementación del método CalcularInteresAnual de la clase base
        public override void CalcularInteresAnual()
        {
            Console.WriteLine("Cuenta de Ahorro: interes Anual");
        }
    }
}
