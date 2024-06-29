

using Ejercicio2_Herencia;

class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.Nombre = "Juan";
        persona.Edad = 30;
        Console.WriteLine("Datos de la persona:");
        persona.Imprimir();

        Empleado empleado = new Empleado();
        empleado.Nombre = "Pedro";
        empleado.Edad = 35;
        empleado.Sueldo = 1500;
        Console.WriteLine("Datos del empleado:");
        empleado.Imprimir();
    }
}