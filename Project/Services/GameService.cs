using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project
{
    public class GameService : IGameService
    {
    public GameService(IGame _game) 
        {
          this._game = _game;
               
        }
                        private IGame _game { get; set; }

        public List<string> Messages { get; set; }
        public GameService()
        {
            _game = new Game();
            Messages = new List<string>();
        }
        public void Go(string direction)
        {
      string from = _game.CurrentRoom.Name;
      _game.CurrentRoom = _game.CurrentRoom.Move(direction);
      string to = _game.CurrentRoom.Name;

      if(from == to) 
      {
        Messages.Add("Invalid Move");
        return;
      }
      Messages.Add($"Moved {from} to {to}");
      Messages.Add($"Room Description {_game.CurrentRoom.Description}");
      throw new System.NotImplementedException();
        }
        public void Help(string input)
        {
      Messages.Add("help"); 
      string Help = _game.CurrentRoom.Help;
      Messages.Add($"{Help}");
      throw new System.NotImplementedException();
        }

        public void Inventory()
        {
      Messages.Add("There is a torch. Do you want to get it?");
      string Choice = Console.ReadLine().ToLower(); 
      if (Choice == "yes")
      




      throw new System.NotImplementedException();
        }

        public void Look(string input)
        {
          Messages.Add($"Looking around {_game.CurrentRoom.Description}");
            throw new System.NotImplementedException();
        }

    public void Quit()
    {
      { 
      Environment.Exit(0);
    }
      throw new System.NotImplementedException();
        }
        ///<summary>
        ///Restarts the game 
        ///</summary>
        public void Reset()
        { 
      throw new System.NotImplementedException();
        }

        public void Setup(string playerName)
        {
      Messages.Add("Chose a name");
      Console.ReadLine(); 
      throw new System.NotImplementedException();
        }
        ///<summary>When taking an item be sure the item is in the current room before adding it to the player inventory, Also don't forget to remove the item from the room it was picked up in</summary>
        public void TakeItem(string itemName)
        {

            throw new System.NotImplementedException();
        }
        ///<summary>
        ///No need to Pass a room since Items can only be used in the CurrentRoom
        ///Make sure you validate the item is in the room or player inventory before
        ///being able to use the item
        ///</summary>
        public void UseItem(string itemName)
        {
      Messages.Add("The room lights up and you can now see");
      Console.ReadLine(); 

      throw new System.NotImplementedException();
        }

    public void Help()
    {
      Messages.Add("To move enter: north, south east or west" + "To look around room enter: look" + "To get an item enter: getitem" + "To use an item enter: useitem");
      throw new NotImplementedException();
    }

    public void Look()
    {
      Messages.Add(_game.CurrentRoom.Description); 
      throw new NotImplementedException();
    }
  }
}