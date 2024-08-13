using Singleton_Before;

class Program
{
    static void Main(string[] args)
    {
        var capitales = SingletonContainer.Instance;
        var capitales1 = SingletonContainer.Instance;
        var capitales2 = SingletonContainer.Instance;
        Console.WriteLine($"Los habitantes de Lima son: {capitales.GetPopulation("Lima")}");
        Console.ReadLine();
    }
}