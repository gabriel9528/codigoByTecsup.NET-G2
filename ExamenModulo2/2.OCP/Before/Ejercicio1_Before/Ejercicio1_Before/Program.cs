
using Ejercicio1_Before;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>()
        {
                new Person{ FirstName = "Rodrigo", LastName="Morales", MembresiaType = MembresiaType.Gold },
                new Person{ FirstName = "Miguel", LastName="Sandoval", MembresiaType = MembresiaType.Platinium },
                new Person{ FirstName = "Robert", LastName="Martin"}
            };

        List<Membership> memberships = new List<Membership>();
        foreach (var person in persons)
        {
            memberships.Add(new AccountService().Create(person));
        }
        foreach (var membership in memberships)
        {
            Console.WriteLine($"Bienvenido {membership.FirstName}, {membership.LastName} , {membership.Email}, Membership ID: {membership.Id}, Price: {membership.Price}" +
                $"Plan Basico: {(membership.MembresiaType == MembresiaType.Basico ? "Si" : "No")}, " +
                $"Plan Gold: {(membership.MembresiaType == MembresiaType.Gold ? "Si" : "No")}, " +
                $"Plan Platinum: {(membership.MembresiaType == MembresiaType.Platinium ? "Si" : "No")} ");
        }
        Console.ReadLine();
    }

}