using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public class CuentaInversion : CuentaBancaria, IRendimientoGenerable
    {
        public double Rendimiento { get; private set; }

        public CuentaInversion(string titular, double rendimiento) : base(titular)
        {
            Rendimiento = rendimiento;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Cuenta de Inversión:");
            base.MostrarInformacion();
        }

        // Método abstracto para calcular interés anual, implementación requerida por la clase base
        public override void CalcularInteresAnual()
        {
            Console.WriteLine("Cálculo del interés anual para la cuenta de inversión.");
        }

        // Implementación del método CalcularRendimientoMensual de la interfaz IRendimientoGenerable
        public void CalcularRendimientoMensual()
        {
            Console.WriteLine("Cálculo del rendimiento mensual para la cuenta de inversión.");
        }
    }

}
