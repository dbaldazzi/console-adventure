using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Game : IGame
  {
    public Game()
    {
    }

    public Game(IRoom currentRoom, IPlayer currentPlayer)
    {
      this.CurrentRoom = currentRoom;
      this.CurrentPlayer = currentPlayer;

    }
    public IRoom CurrentRoom { get; set; }
    public IPlayer CurrentPlayer { get; set; }

    //NOTE Make yo rooms here...
    public void Setup()
    { //rooms 
      Room ew = new Room("ew", "entry way");
      Room mh = new Room("mh", "main halll");
      Room twr = new Room("twr", "tower");
      Room vw = new Room("vw", "Room with a view");
      Room str = new Room("str", "Stair way");
      Room wr = new Room("wr", "Weapons Room");

      Dictionary<string, string> Exits = new Dictionary<string, string>();
      Exits.Add("north", "");


      //room connections 
      ew.AddConnection(mh);
      mh.AddConnection(str);
      str.AddConnection(twr);
      twr.AddConnection(vw);
      mh.AddConnection(wr);
      wr.AddConnection(str);

      //creating items
      Item torch = new Item("lights the room");

      // Items in rooms
      ew.Items.Add(torch);

      //starting room 
      CurrentRoom = ew;




      throw new System.NotImplementedException();
    }
    //     public Game()
    //     {
    //   Room = new Room();
    //   Setup(); 
  }
}

