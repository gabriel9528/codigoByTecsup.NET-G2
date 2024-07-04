

using LSP_Ejercicio1_BEFORE;

class Program
{
    static void Main(string[] args)
    {
        Player player = new FootbalPlayer();
        player.FirstName = "Gabriel";
        player.LastName = "Retamozo";
        player.AssignTeam(new Team { Name = "MELGAR" });
        player.SetCategory(PlayerCategoria.Professional);

        Console.WriteLine($"{player.FirstName} {player.LastName} equipo: {player.GetTeam()} categoria{player.Category}");
        Console.ReadLine();
    }
}