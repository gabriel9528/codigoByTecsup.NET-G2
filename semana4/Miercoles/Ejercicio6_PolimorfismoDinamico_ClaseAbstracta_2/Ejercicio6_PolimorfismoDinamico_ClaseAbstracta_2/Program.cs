
using Ejercicio6_PolimorfismoDinamico_ClaseAbstracta_2;

public class Program
{
    public static void Main(string[] args)
    {
        Forma[] formas = new Forma[3];
        formas[0] = new Circulo(4);
        formas[1] = new Cuadrado(5);
        formas[2] = new Triangulo(10, 6);

        for (int i = 0; i < formas.Length; i++)
        {
            Console.WriteLine($"Area: " + formas[i].Area());
            Console.WriteLine($"Perimetro: " + formas[i].Perimetro());
        }
    }
}