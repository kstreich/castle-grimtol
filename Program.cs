using System;
using CastleGrimtol.Project;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Clear();
      Console.Write("Please enter your name: ");
      string name;
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

      Player player = new Player(name);

      Console.WriteLine("It's time to pay close attention...");
      Console.WriteLine("\n You are making your journey though an enchanted forest, but need to stop to rest for the night. Luckily for you, there is what looks to be, an abandoned mansion up a head. You decide to check it out.");


      GameService gamePlay = new GameService();
      gamePlay.CurrentPlayer = player;
      gamePlay.Setup();
      //do you want to play or more story line here before gameplay
      //then
      gamePlay.StartGame();

    }
  }
}
