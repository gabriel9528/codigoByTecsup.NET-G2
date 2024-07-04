

using LSP_Ejercicio2_Before;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dog();
        animal.Noise = "birdddddddd";
        animal.MakeNoise();
        animal.Fly();
        Console.ReadLine();
    }
}