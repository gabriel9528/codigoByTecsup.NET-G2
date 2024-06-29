
using Ejercicio1_Abstraccion;

public class Program
{
    static void Main()
    {
        Producto laptop = new Producto("Huawei", 2000, 10);
        Producto celular = new Producto("Iphone", 1800, 15);
        Producto auriculares = new Producto("Samsung", 500, 20);

        List<Producto> productos = new List<Producto>();
        laptop.RestarStock(5);

        productos.Add(laptop);
        productos.Add(celular);
        productos.Add(auriculares);

        //calcular el total de ventas
        decimal totalVentas = Producto.CalcularTotalVentas(productos);
        Console.WriteLine("El total de ventas es: " + totalVentas);
    }
}