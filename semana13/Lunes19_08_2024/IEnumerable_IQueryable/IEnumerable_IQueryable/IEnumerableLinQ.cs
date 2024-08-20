using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IQueryable
{
    public class IEnumerableLinQ
    {
        public static void Main()
        {
            //*------------------IEnumerable------------------*
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "John", Salary = 10000 },
                new Employee { Id = 2, Name = "Marry", Salary = 20000 },
                new Employee { Id = 3, Name = "Smith", Salary = 30000 },
            };

            IEnumerable<Employee> query = from employee in listEmployees
                                          where employee.Salary > 15000
                                          select employee;

            foreach(var item in query)
            {
                Console.WriteLine(item.Name);
            }

            //*------------------IQueryable------------------*
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IQuerayable");
            IQueryable<Employee> employees = listEmployees.AsQueryable().Where(x => x.Salary > 5000);
            foreach(var item in employees)
            {
                Console.WriteLine(item.Name);
            }

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
    }
}
