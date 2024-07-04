
using ISP_Ejercicio2_Before;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bicicleta:");
        IVehiculo bicicleta = new Bicicleta();
        bicicleta.Move();
        Console.WriteLine(bicicleta.GetNumberOfWheel());
        
        //bicicleta.StartEngine();
        //bicicleta.StopEngine();

        Console.WriteLine("*------------------------------------------*");
        Console.WriteLine("Automovil:");
        IVehiculo automovil = new Automovil();
        automovil.Move();
        Console.WriteLine(automovil.GetNumberOfWheel());
        automovil.StartEngine();
        automovil.StopEngine();
    }
}