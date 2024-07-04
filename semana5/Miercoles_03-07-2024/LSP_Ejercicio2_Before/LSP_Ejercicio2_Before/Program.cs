

using LSP_Ejercicio2_Before;

class Program
{
    static void Main(string[] args)
    {
        IAnimal animal = new Dog();
        animal.Noise = "guguagua";
        animal.MakeNoise();
        //animal.Fly();
        Console.ReadLine();
    }
}