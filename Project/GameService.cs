using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project
{
  public class GameService : IGameService
  {
    public IRoom CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void GetUserInput()
    {
      throw new System.NotImplementedException();
    }

    public void Go(string direction)
    {
      throw new System.NotImplementedException();
    }

    public void Help()
    {
      throw new System.NotImplementedException();
    }

    public void Inventory()
    {
      throw new System.NotImplementedException();
    }

    public void Look()
    {
      throw new System.NotImplementedException();
    }

    public void Quit()
    {
      throw new System.NotImplementedException();
    }

    public void Reset()
    {
      throw new System.NotImplementedException();
    }

    public void Setup()
    {
      //create rooms here
      Room room1 = new Room("Outside", "You are making your journey though an enchanted forrest, but need to stop to rest for the night. Luckily for you, there is what looks to be, an abandoned mansion up a head. You decide to check it out.");
      Room room2 = new Room("Entry way", "Here you are amazed at the craftsmanship of the entry room. A grand stair case is a head of you (east) and to your left is the kitchen, while to the right is the living room.");
      Room room3 = new Room("Shed", "Wow, this shed is crazy old”, you mumble to yourself as you enter inside. But despite its apparent dilapidation there are a lot of neat things in it. Three of which are a hammer, a shovel, and an axe.");
      Room room4 = new Room("Living Room", "Here you notice a finely furnished room, with a grand piano and a fully stocked bar");
      Room room5 = new Room("Dining Room", "As you open the door to the dining room, the smell of freshly cooked food awakens your hunger. Along the grand dining table are various dishes of meats of all kinds, steamed and sautéed vegetables, breads and pastas, and anything else a person could imagine. To the right (east) is the door to the kitchen");
      Room room6 = new Room("Kitchen", "As you walked into the kitchen you noticed how immaculate and clean it looked. Someone has to be here maintaining it, and who cooked all of the food? Out of impulse you yell, “Heellllooo, is anyone in here?");
      Room room7 = new Room("Stairs", "The beautiful winding stair case looked to lead to a hallway of rooms. “Maybe you could find a safe place to stay the night?” you think to yourself.");
      Room room8 = new Room("HallWay", "After climbing the stairs there are 3 doors (north, east, and south). You quickly shake the handles of all three doors, but they are locked. Then you remembered the key the ghost gave you upon entering the house…");





      //current room equals the outside room, set this up at the end

    }

    public void StartGame()
    {
      throw new System.NotImplementedException();
    }

    public void TakeItem(string itemName)
    {
      throw new System.NotImplementedException();
    }

    public void UseItem(string itemName)
    {
      throw new System.NotImplementedException();
    }
  }
}