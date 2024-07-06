using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before
{
    public class FullTime : Employee
    {
        public FullTime()
        {
            ContractTypee = ContractType.Planilla;
        }
        public string GetSalarioFijo()
        {
            string salario = "";
            if (string.IsNullOrEmpty(Department.Name))
            {
                new NotImplementedException("Al asignar un departamento, tiene que enviar un departamento valido");
            }
            else
            {
                salario = "5000";
            }
            return salario;
        }
    }
}
