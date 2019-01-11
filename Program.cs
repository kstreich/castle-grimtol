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
      Console.WriteLine("Your objective is to survive your journey");

      Console.WriteLine(@"
Here are some of your console commands
        go - moves you from room to room
        take - add item to your inventory
        use<item> - use an item from your inventory or from room
        look - displays the description of the current room
        inventory - will display a list items in your inventory

You can refer to this list by typing in 'help'
      ");

      Console.WriteLine("Are you ready to play? (Y/N)");
      string startInput = Console.ReadLine();
      string name = "";

      if (startInput == "Y" || startInput == "y")
      {
        Console.Clear();
        Console.Write("Please enter your name: ");
        while (true)
        {
          name = Console.ReadLine();
          if (name.Length < 1)
          {
            continue;
          }
          Console.Clear();
          break;
        }

      }
      else if (startInput == "N" || startInput == "n")
      {
        gamePlay.Quit();
      }

      Player player = new Player(name);

      Console.WriteLine("It's time to pay close attention...");

      Console.WriteLine("\n You are making your journey though an enchanted forest, but need to stop to rest for the night. Luckily for you, there is what looks to be, an abandoned mansion up a head. You decide to check it out.");


      gamePlay.CurrentPlayer = player;

      gamePlay.Setup();
      //do you want to play or more story line here before gameplay
      //then

      gamePlay.StartGame();

    }
  }
}
