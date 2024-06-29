using Interfaces1;

class Program
{
    static void Main(string[] args)
    {
        // Crear cuentas bancarias
        ICuentaBancaria cuenta1 = new CuentaAhorro("John Doe", 2.5);
        ICuentaBancaria cuenta2 = new CuentaCorriente("Jane Smith", 500);
        ICuentaBancaria cuenta3 = new CuentaInversion("Alice Johnson", 5);

        // Realizar operaciones en las cuentas
        cuenta1.Depositar(1000);
        cuenta1.Retirar(200);
        ((IInteresGenerable)cuenta1).CalcularInteresMensual();
        ((CuentaAhorro)cuenta1).CalcularInteresAnual();
        Console.WriteLine("==========================");
        cuenta2.Depositar(1500);
        cuenta2.Retirar(700);
        Console.WriteLine("==========================");
        cuenta3.Depositar(2000);
        ((IRendimientoGenerable)cuenta3).CalcularRendimientoMensual();
        Console.WriteLine("====================================================================================");
        // Mostrar información de las cuentas
        Console.WriteLine("Información de las Cuentas:");

        cuenta1.MostrarInformacion();
        Console.WriteLine("==========================");
        Console.WriteLine();
        cuenta2.MostrarInformacion();
        Console.WriteLine("==========================");
        Console.WriteLine();
        cuenta3.MostrarInformacion();
        Console.WriteLine("==========================");

        Console.ReadLine();
    }
}