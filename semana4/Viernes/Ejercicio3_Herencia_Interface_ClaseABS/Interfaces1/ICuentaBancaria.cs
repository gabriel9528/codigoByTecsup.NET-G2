using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces1
{
    // Interface para cuentas bancarias
    public interface ICuentaBancaria
    {
        void Depositar(double cantidad);
        void Retirar(double cantidad);
        void MostrarInformacion();
    }
}
