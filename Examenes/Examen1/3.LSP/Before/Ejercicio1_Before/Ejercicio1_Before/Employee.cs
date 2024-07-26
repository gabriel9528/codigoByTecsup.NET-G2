using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public ContractType ContractTypee { get; set; }

        public string GetDepartment() => Department.Name;

        public virtual void AssignDepartment(Department department)
        {
            Department = department;
        }

        public virtual void SetContractType(ContractType contractType)
        {
            ContractTypee = contractType;
        }
    }
}
