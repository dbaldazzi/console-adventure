using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Item : IItem
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Item(IRoom name, string description)
    {
     
      Description = description;
    }

    public Item(string v)
    {
    }
  }
}