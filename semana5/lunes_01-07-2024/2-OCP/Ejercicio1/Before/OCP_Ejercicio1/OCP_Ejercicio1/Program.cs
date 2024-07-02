
using OCP_Ejercicio1;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Person> persons = new List<Person>()
        {
            new Person() { FirstName = "Gabriel", LastName = "Retamozo", Role = Role.Doctor},
            new Person() { FirstName = "Andre", LastName = "Flores", Role = Role.Nurse},
            new Person() { FirstName = "Juanito", LastName = "Ramos", Role = Role.None}
        };

        List<Staff> staffs = new List<Staff>();
        foreach(var person in persons)
        {
            staffs.Add(new AccountService().Create(person));
        }

        foreach(var staff in staffs)
        {
            Console.WriteLine($"Nombres: {staff.FirstName}, Apellido: {staff.LastName}, correo -> {staff.Email},Es doctor: {(staff.Role == Role.Doctor ? "Si es doctor" : "No es doctor")}, ,Es Enfermera: {(staff.Role == Role.Nurse ? "Si es enfermera" : "No es enfermera")}");
        }
        Console.ReadLine();
    }
}