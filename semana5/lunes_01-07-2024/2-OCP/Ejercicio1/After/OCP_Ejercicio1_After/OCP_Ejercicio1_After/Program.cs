
using OCP_Ejercicio1_After;

class Program
{
    static void Main(string[] args)
    {
        List<IPerson> personas = new List<IPerson>()
        {
            new Person{ FirstName = "Juan", LastName = "Perez",},
            new Doctor{ FirstName = "Pedro", LastName = "Gomez"},
            new Nurse{ FirstName = "Andrea", LastName = "Torres"},
            new Seguridad{ FirstName = "Jorgito", LastName = "Lopez"}
        };

        List<Staff> staffs = new List<Staff>();
        foreach (var item in personas)
        {
            staffs.Add(item.IAccountService.Create(item));
        }

        foreach(Staff x in staffs)
        {
            Console.WriteLine($"Bienvenido {x.FirstName} {x.LastName} - {x.Email}");
        }
    } 
}