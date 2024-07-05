
using Ejercicio1_Before;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>()
        {
                new Person{ FirstName = "Rodrigo", LastName="Morales", MembresiaType = MembresiaType.Trimestral },
                new Person{ FirstName = "Miguel", LastName="Sandoval", MembresiaType = MembresiaType.Anual },
                new Person{ FirstName = "Robert", LastName="Martin"}
            };

        List<Membership> memberships = new List<Membership>();
        foreach (var person in persons)
        {
            memberships.Add(new AccountService().CreateMembership(person));
        }
        foreach (var membership in memberships)
        {
            Console.WriteLine($"Bienvenido {membership.FirstName}, {membership.LastName} , {membership.Email}, Membership ID: {membership.Id}, Price: {membership.Price}" +
                $"Plan Mensual: {(membership.MembresiaType == MembresiaType.Mensual ? "Si" : "No")}, " +
                $"Plan Trimestral: {(membership.MembresiaType == MembresiaType.Trimestral ? "Si" : "No")}, " +
                $"Plan Anual: {(membership.MembresiaType == MembresiaType.Anual ? "Si" : "No")} ");
        }
        Console.ReadLine();
    }

}