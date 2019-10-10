using System.Collections.Generic;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project.Interfaces
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        string Help { get; set; }
    List<IItem> Items { get; set; }
        Dictionary<string, IRoom> Exits { get; set; }

    IRoom Move(string destinationRoom);

    string GetTemplate();
    
  }
}
