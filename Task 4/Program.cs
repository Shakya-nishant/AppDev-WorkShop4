namespace Task_4;
class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player();
        player1.playerName = "First Player";
        player1.level = 1;
        player1.health = 100;

        Player player2 = new Player("Second Player", 50, 1000);

        Console.WriteLine("\nPlayer 1");
        Console.WriteLine($"Name   : {player1.playerName}");
        Console.WriteLine($"Level  : {player1.level}");
        Console.WriteLine($"Health : {player1.health}");

        Console.WriteLine("\nPlayer 2");
        Console.WriteLine($"Name   : {player2.playerName}");
        Console.WriteLine($"Level  : {player2.level}");
        Console.WriteLine($"Health : {player2.health}");


    }
}
