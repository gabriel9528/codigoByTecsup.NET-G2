
using Ejercicio2_Abstraccion;

public class Program
{
    static void Main()
    {
        Empleado empleado1 = new Empleado();
        empleado1.Nombre = "Juan";
        empleado1.Edad = 30;
        empleado1.Salario = 2000;

        Empleado empleado2 = new Empleado();
        empleado1.Nombre = "Gabriel";
        empleado1.Edad = 25;
        empleado1.Salario = 2000;

        var salarioAnual = Empleado.CalcularSalarioAnual(empleado1.Salario);
        var salarioAnual2 = Empleado.CalcularSalarioAnual(empleado2.Salario);

        Console.WriteLine($"El salario anual de {empleado1.Nombre} es de {salarioAnual}");
        Console.WriteLine($"El salario anual de {empleado2.Nombre} es de {salarioAnual2}");
    }
}