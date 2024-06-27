
using Ejercicio4_PolimorfismoEstatico;

public class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        int resultadoEntero = calculadora.Suma(5, 6);
        double resultadoDouble = calculadora.Suma(3.5, 4.2);

        Console.WriteLine($"Resultado entero: " + resultadoEntero);
        Console.WriteLine($"Resultado doble: " + resultadoDouble);
    }
}