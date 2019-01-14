using System;
using CastleGrimtol.Project;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {
      GameService gamePlay = new GameService();
      Console.Clear();
      Console.WriteLine("Your objective is to survive your journey.");

      Console.WriteLine(@"
Console commands
        go <direction> - moves you from room to room
        take <item> - add item to your inventory
        use <item> - use an item from your inventory or from room
        look - displays the description of the current room
        inventory - will display a list items in your inventory

You can refer to this list by typing in 'help'
      ");

      // Console.WriteLine("Are you ready to play? (Y/N)");
      // string startInput = Console.ReadLine();
      string name;
      Console.WriteLine("Please enter your name");
      name = Console.ReadLine();



      Player player = new Player(name);

      Console.WriteLine($"It's time to pay close attention {name}");

      Console.WriteLine("\n You are making your journey though an enchanted forest, but need to stop to rest for the night. Luckily for you, you think you see a structure...");


      gamePlay.CurrentPlayer = player;

      gamePlay.Setup();
      //do you want to play or more story line here before gameplay
      //then

      gamePlay.StartGame();

    }
  }
}
