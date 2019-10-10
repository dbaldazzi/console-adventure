using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Player : IPlayer
  {
    public string Name { get; set; }
    public List<Item> Inventory { get; set; }

    public string GetTemplate()
  {
      string template = "Inventory: \n"; 
      foreach (var item in Inventory)
      {
        template += $"{item.Name}: {item.Description:item} \n"; 
      }
      return template + $"Inventory: {Inventory:item}"; 
    }
    public Player()
    {
       
      Inventory = new List<Item>();
    }
}
}