

using FactoryMethod1;

class Program
{
    static void Main(string[] args)
    {
        var usuario = Usuario.UsuarioFactory.CreateWithDefaultEmail("Gabriel", "Peru");
        var usuario2 = Usuario.UsuarioFactory.CreateWithDefaultCountry("Gabriel", "gabriel@gmail.com");
        Console.WriteLine($"Usuario: {usuario.Name}, Email:{usuario.Email}, Pais: {usuario.Country}");
        Console.WriteLine($"Usuario: {usuario2.Name}, Email:{usuario2.Email}, Pais: {usuario2.Country}");
        Console.ReadLine();
    }

}