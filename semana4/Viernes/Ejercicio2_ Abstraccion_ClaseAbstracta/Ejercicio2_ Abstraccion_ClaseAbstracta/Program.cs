

using Ejercicio2__Abstraccion_ClaseAbstracta;

public class Program
{
    static void Main()
    {
        Dispositivo telefonoMovil = new TelefonoMovil("Samsung", "Galaxy S10", "2019");
        Dispositivo tablet = new Tablet("Samsung", "Galaxy S10", "2019");
        Dispositivo laptop = new Laptop("Samsung", "Galaxy S10", "2019");

        telefonoMovil.Encender();
        telefonoMovil.Apagar();
        telefonoMovil.ObtenerInfo();

        tablet.Encender();
        tablet.Apagar();
        tablet.ObtenerInfo();

        laptop.Encender();
        laptop.Apagar();
        laptop.ObtenerInfo();
    }
}