using Builder_Before;

class Program
{
    static void Main(string[] args)
    {
        //var sandwisch = new Sandwich("pan de molde", "tomates", "proteina A", "mayonesa", "queso cheddar");

        var cheeseBurger = new SandwichAssembly(new CheeseBurger());
        cheeseBurger.Assemblly();

        Console.WriteLine($"{cheeseBurger.GetSandwich.Pan}, " +
            $" {cheeseBurger.GetSandwich.Verduras}, " +
            $" {cheeseBurger.GetSandwich.Proteina}, " +
            $" {cheeseBurger.GetSandwich.Condimentos}, " +
            $" {cheeseBurger.GetSandwich.Queso} "
            );

        Console.ReadLine();
    }
}