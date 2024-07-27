
using FluentBuilder_Sandwich;

class Program
{
    static void Main(string[] args)
    {
        var builder = new SandwichBuilder()
            .AddPan()
            .AddProteina()
            .AddQueso()
            .AddVerduras()
            .AddCondimentos();

        Sandwich sandwich = builder.Sandwich;
        Console.WriteLine($"Sandwich cheese Burger: {sandwich}");

    }
}