using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project
{
  public class GameService : IGameService
  {
    public IRoom CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }
    public bool Playing { get; set; } = true; //sets default value of property

    public void GetUserInput()
    {
      string playerInput;

      System.Console.WriteLine("Please enter in what you would like to do");
      playerInput = System.Console.ReadLine();
      string[] inputArr = playerInput.Split(" ");
      string command = inputArr[0];
      //split the string and add to an array then use array[0]

      while (true)
      {
        switch (command.ToUpper())
        {
          case "GO":
            Go(inputArr[1]);
            break;
          case "TAKE":
            TakeItem(inputArr[1]);
            break;
          case "LOOK":
            Look();
            break;
          case "USE":
            UseItem(inputArr[1]);
            break;
          case "INVENTORY":
            Inventory();
            break;

        };
      }
    }
    public void Go(string direction)
    {
      if (CurrentRoom.Exits.ContainsKey(direction))
      {
        CurrentRoom = CurrentRoom.Exits[direction];
        System.Console.WriteLine(CurrentRoom.Description);
      }




      // while (true)
      // {
      //   switch (CurrentRoom.Exits.ContainsKey(direction.ToUpper()))
      //   {
      //     case "NORTH":
      //       System.Console.WriteLine(CurrentRoom.Description);
      //       break;
      //     case "SOUTH":
      //       System.Console.WriteLine(CurrentRoom.Description);
      //       break;
      //     case "WEST":
      //       System.Console.WriteLine(CurrentRoom.Description);
      //       break;
      //     case "EAST":
      //       System.Console.WriteLine(CurrentRoom.Description);
      //       break;
      //   }
      // }


    }

    public void Help()
    {
      System.Console.WriteLine("Below is your list of commands: ");
      System.Console.WriteLine(@"
        go - moves you from room to room
        take <item> - add item to your inventory
        use <item> - use an item from your inventory or from room
        look - displays the description of the current room
        inventory - will display a list items in your inventory
      ");
      GetUserInput();
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
      //Rooms
      #region
      Room room1 = new Room("Outside", "You are making your journey though an enchanted forrest, but need to stop to rest for the night. Luckily for you, there is what looks to be, an abandoned mansion up a head. You decide to check it out.");
      Room room2 = new Room("Entry way", "Here you are amazed at the craftsmanship of the entry room. A grand stair case is a head of you (east) and to your left is the kitchen, while to the right is the living room.");
      Room room3 = new Room("Shed", "Wow, this shed is crazy old”, you mumble to yourself as you enter inside. But despite its apparent dilapidation there are a lot of neat things in it. Three of which are a hammer, a shovel, and an axe.");
      Room room4 = new Room("Living Room", "Here you notice a finely furnished room, with a grand piano and a fully stocked bar");
      Room room5 = new Room("Dining Room", "As you open the door to the dining room, the smell of freshly cooked food awakens your hunger. Along the grand dining table are various dishes of meats of all kinds, steamed and sautéed vegetables, breads and pastas, and anything else a person could imagine. To the right (east) is the door to the kitchen");
      Room room6 = new Room("Kitchen", "As you walked into the kitchen you noticed how immaculate and clean it looked. Someone has to be here maintaining it, and who cooked all of the food? Out of impulse you yell, “Heellllooo, is anyone in here?");
      Room room7 = new Room("Stairs", "The beautiful winding stair case looked to lead to a hallway of rooms. “Maybe you could find a safe place to stay the night?” you think to yourself.");
      Room room8 = new Room("HallWay", "After climbing the stairs there are 3 doors (north, east, and south). You quickly shake the handles of all three doors, but they are locked. Then you remembered the key the ghost gave you upon entering the house…");
      Room room9 = new Room("Bed Room 1", "Shocked that the key you have worked, you turn the handle. As the door is slowly opening, a very bright light is shining out of the room. The air is warm and smells sweet, like the beginning of spring. The light begins to dim and you recognize the surrounding garden as your home. In your cottage you see the silhouette of your beloved family.");
      Room room10 = new Room("Bed Room 2", "Shocked that the key you have worked, you turn the handle. As you push the door open, you get shoved into the room and the door instantly locks behind you. The room is completely dark, so much so that you can almost feel the darkness around you. You hear a low grumbling sound behind you. Turning to face the sound you see a pair of bring yellow eyes staring at you. The next moment you’ve been forced to the ground and the creature is ripping you apart with its razor sharp teeth");
      Room room11 = new Room("Bed Room 3", "Shocked that the key you have worked, you turn the handle. As you push the door open, you get shoved into the room and the door instantly locks behind you. The room is very dimly lit and you feel spider webs brushing against your face. As you push through the rooms the webs get thicker and thicker to where movement is being hindered. Before you know it, a spider the size of a human has you locked in its fangs.");
      #endregion
      //Dead Rooms
      #region
      Room room1N = new Room("Death", "Heading north, you decided that you would take your chances by continuing your journey in the forest. Sadly though, your fate was in the hands of death, particularly a ravenous werewolf");
      Room room1W = new Room("Death", "You decided that your weren’t going to risk it in the mansion and you’d rather test your survival skills and camp outside. But creating a fire proved more challenging in the rain and you died of hypothermia and leeches");
      Room room2W = new Room("Locked", "You try unlocking the door, but the bolt won’t budge");
      Room room3SWE = new Room("Walls", "This is just a wall, go north");
      Room room5NE = new Room("Walls", "This is just a wall, go east or south");
      Room room6NES = new Room("Walls", "This is just a wall, go west");
      Room room7NS = new Room("Stairs", "Jumping off the stairs is discourage, go east (back) or west(forward)");
      Room wall = new Room("Wall", "This is just a wall");
      Room lockedDoor = new Room("Locked", "This door is locked and you have no way of unlocking it");

      #endregion
      //Exits
      #region
      room1.Exits.Add("north", room1N);
      room1.Exits.Add("south", room3);
      room1.Exits.Add("west", room1W);
      room1.Exits.Add("east", room2);

      room2.Exits.Add("north", room5);
      room2.Exits.Add("south", room4);
      room2.Exits.Add("west", room2W);
      room2.Exits.Add("east", room7);

      room3.Exits.Add("north", room1);
      room3.Exits.Add("south", room3SWE);
      room3.Exits.Add("west", room3SWE);
      room3.Exits.Add("east", room3SWE);

      room4.Exits.Add("north", room2);
      room4.Exits.Add("south", room3SWE);
      room4.Exits.Add("west", room3SWE);
      room4.Exits.Add("east", room3SWE);

      room5.Exits.Add("north", room5NE);
      room5.Exits.Add("south", room2);
      room5.Exits.Add("west", room5NE);
      room5.Exits.Add("east", room6);

      room6.Exits.Add("north", room6NES);
      room6.Exits.Add("south", room6NES);
      room6.Exits.Add("west", room5);
      room6.Exits.Add("east", room6NES);


      room7.Exits.Add("north", room7NS);
      room7.Exits.Add("south", room7NS);
      room7.Exits.Add("west", room2);
      room7.Exits.Add("east", room8);

      room8.Exits.Add("north", room9);
      room8.Exits.Add("south", room11);
      room8.Exits.Add("west", room7);
      room8.Exits.Add("east", room10);

      #endregion
      //Items
      #region 
      //Room 2
      Item key1 = new Item("Key 1", "Brass skeleton key");
      room2.Items.Add(key1);
      Item key2 = new Item("Key 2", "Short stubby key");
      room2.Items.Add(key2);
      Item key3 = new Item("Key 3", "Jewel encrusted key");
      room2.Items.Add(key3);
      //Room 3
      Item axe = new Item("Axe", "A woodchopping axe");
      room3.Items.Add(axe);
      // Room 4
      Item food = new Item("Food", "Loaf of bread");
      room5.Items.Add(food);


      #endregion


      Room currentRoom = room1;
    }

    public void StartGame()
    {
      while (Playing)
      {
        GetUserInput();
      };
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