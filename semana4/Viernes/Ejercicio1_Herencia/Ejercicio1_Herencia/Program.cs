
using Ejercicio1_Herencia;

public class Program
{
    static void Main()
    {
        Suma suma = new Suma();
        suma.Valor1 = 10;
        suma.Valor2 = 5;
        suma.Operar();
        Console.WriteLine("La suma de {0} + {1} = {2} ----> {3}", suma.Valor1, suma.Valor2, suma.Resultado, suma.Resultado);

        Resta resta = new Resta();
        resta.Valor1 = 10;
        resta.Valor2 = 5;
        resta.Operar();
        Console.WriteLine("La resta de {0} - {1} = {2} ----> {3}", resta.Valor1, resta.Valor2, resta.Resultado, resta.Resultado);
    }
}