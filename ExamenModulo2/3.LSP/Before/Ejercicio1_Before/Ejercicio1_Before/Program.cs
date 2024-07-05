using Ejercicio1_Before;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new FullTime();
        employee.FirstName = "Gabriel";
        employee.LastName = "Retamozo";
        employee.AssignDepartment(new Department { Name = "IT" });
        employee.SetContractType(ContractType.Planilla);

        Console.Write($"{employee.FirstName} {employee.LastName} departamento: {employee.GetDepartment()} tipo de empleo:  {employee.ContractType}");
        Console.ReadLine();
    }
}