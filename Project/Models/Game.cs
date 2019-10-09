using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
    public class Game : IGame
    {
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

//room connections 
      ew.AddConnection(mh);
      mh.AddConnection(str);
      str.AddConnection(twr);
      twr.AddConnection(vw);
      mh.AddConnection(wr);
      wr.AddConnection(str);

//starting room 
      CurrentRoom = ew; 




      throw new System.NotImplementedException();
        }
    }
}