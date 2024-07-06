
using DIP_Ejercicio1_Before;

class Program
{
    static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Rodrigo", Gender = Gender.Male, Role = Role.Executive },
            new Employee { Name = "Gabriel", Gender = Gender.Male, Role = Role.Manager },
            new Employee { Name = "Rosa", Gender = Gender.Female, Role = Role.Developer },
            new Employee { Name = "Jorge", Gender = Gender.Male, Role = Role.Executive },
        };
        var employeeManager = new EmployeeManager();
        foreach (var item in employees)
        {
            employeeManager.Save(item);
        }
        var search = new EmployeeSearch(employeeManager);

        Console.WriteLine(search.GetMaleExecutives());

    }
}