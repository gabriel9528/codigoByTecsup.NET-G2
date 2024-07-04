

using ISP_Ejercicio2_After;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Automovil:");
        Automovil automovil = new Automovil();
        automovil.Move();
        Console.WriteLine($"Numero de llantas del automovil: {automovil.GetNumberOfWheel()}");
        Console.WriteLine(automovil.StartEngine());
        Console.WriteLine(automovil.StopEngine());

        Console.WriteLine("*--------------------------------------------------------------*");
        Console.WriteLine("Bicicleta:");
        Bicicleta bicicleta = new Bicicleta();
        bicicleta.Move();
        Console.WriteLine($"Numero de llantas de la bicicleta: {bicicleta.GetNumberOfWheel()}");

    }
}