using System.Collections.Generic;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project.Interfaces
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }
        Dictionary<string, IRoom> Exits { get; set; }

    IRoom Move(string destinationRoom);

    string GetTemplate();
    // IRoom Exits(string direction);
    // public void AddExits(IRoom Room)
    // {
    //   Exits.Add(Room.Name, Room); 
    // }

    // public IRoom Move(string destinationRoom) 
    // {
    //     if (Exits.ContainsKey(destinationRoom))
    //     {
    //     return Exits[destinationRoom];
    //   }
    //   return this; 
    // }
    // public string GetTemplate()
    // {
    //   string template = $"Room: ({Name}) {name} \nConnections: \n"; 
    //   foreach (var Connection in Connection)
    //   {
    //     template += "\t" + Connection.key + " - " + connectionValue.Name + Environment.NewLine; 
    //   }
    //   return template; 
    // }
    // public Room(string code, string name) 
    // {
    //   Code = code;
    //   Name = name;
    //   Items = new List<IItems>();
    //   Connections = new Dictionary<string, IRoom>(); 
    // }
  }
}
