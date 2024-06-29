using Ejercicio4_Abstraccion_ClaseAbstracta;

public class Program
{
    static void Main()
    {
        Vehiculo coche = new Coche("Ford", "Fiesta");
        Vehiculo camion = new Camion("Volvo", "FH");
        Vehiculo motocicleta = new Motocicleta("Yamaha", "FZ", 2021);

        Vehiculo[] vehiculos = new Vehiculo[]
        {
            camion,
            coche,
            motocicleta
        };

        foreach (var vehiculo in vehiculos)
        {
            vehiculo.Iniciar();
            vehiculo.Detener();
            vehiculo.ObtenerDetalles();
        }
    }
}