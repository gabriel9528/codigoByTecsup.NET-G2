

using LSP_Ejercicio1_AFTER;

class Program
{
    static void Main(string[] args)
    {
        IPlayerTeam player = new FootbalPlayer();
        player.FirstName = "Lionel";
        player.LastName = "Messi";
        //player.Team = new Team { Name = "Barcelona" };
        player.AssignTeam(new Team { Name = "Barcelona" });
        player.SetCategory(PlayerCategory.Professional);

        Console.Write($"{player.FirstName} {player.LastName}  categoria:  {player.Category}");
        Console.ReadLine();

    }
}