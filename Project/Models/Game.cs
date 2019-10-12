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
      Room ew = new Room("ew", "entry way", "there is a torch do you wish to take it?", "long wide halway with torches lining the walls", "north");
      Room mh = new Room("mh", "main hall", "", "you are now in a vast room that is dimly lit but you can make out a enormous table in the middle of the room", "north, east, west");
      Room twr = new Room("twr", "tower", "", "you are in a tower with large windows high above your city you are now the leader of this great city and you have won this adventure", "south");
      Room vw = new Room("vw", "Room with a view", "", "you are in a sparce room with a large window on the far side which might help you get your barrings", "west");
      Room str = new Room("str", "Stair way", "", "you are now in a very dark room, doesn't feel very big, but you can't see your hand infront of your face", "north, south");
      Room wr = new Room("wr", "Weapons Room", "", "you are in a small room filled with weapons and armor all locked away", "west");
      Room br = new Room("br", "Bell Room", "", "you have entered a room with a large bell", "north, south"); 

      Dictionary<string, string> Exits = new Dictionary<string, string>();
      ew.Exits.Add("north", mh);
      mh.Exits.Add("east", vw);
      mh.Exits.Add("west", wr);
      mh.Exits.Add("north", str);
      mh.Exits.Add("south", ew);
      vw.Exits.Add("west", mh); 
      wr.Exits.Add("east", mh);
      wr.Exits.Add("east", mh);
      str.Exits.Add("north", br);
      str.Exits.Add("south", mh);
      br.Exits.Add("north", twr);
      twr.Exits.Add("south", br); 



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

