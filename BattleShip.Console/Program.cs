using System;
using BattleShip.API.Controllers;
using BattleShip.API.Models.Boards;
using BattleShip.API.Utilities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n Press Enter to start the Game");
        Console.ReadLine();
        BattleShipController controller = new BattleShipController();
        controller.CreateBoard();

        Console.WriteLine("\n The BattleShip Board is Created");
        Console.WriteLine("\n Press Enter to place the battle ships on the board");
        Console.ReadKey();
        controller.PlaceBattleShips();

        Console.WriteLine("\n");
        Console.WriteLine("\n The battle ships are added on the board");
        Console.WriteLine("\n Press any key to Attack at 2, 4 coordinates");
        Console.ReadKey();

        Coordinates coordinates = new Coordinates(2, 4);
        var status = controller.Attack(coordinates);
        Console.WriteLine("\n The Attack is a " + status);

        if (status == TargetType.Hit.ToString())
            Console.WriteLine("\n Congratulations... you won the game.");
        else if (status == TargetType.Miss.ToString())
            Console.WriteLine("\n Sorry... you lost the game.");
        
        Console.ReadLine();
        return;

    }
}
