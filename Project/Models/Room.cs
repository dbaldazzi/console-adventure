using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Room : IRoom
  {
    public Room(string name, string description)
    {
      this.Name = name;
      this.Description = description;

    }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }
    public string Help { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    List<IItem> IRoom.Items { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void AddConnection(IRoom Room)
    {
      Exits.Add(Room.Name, Room);
    }

    public IRoom Move(string destinationRoom)
    {
      if (Exits.ContainsKey(destinationRoom))
      {
        return Exits[destinationRoom];
      }
      return this;
    }
    public string GetTemplate()
    {
      string template = $"Room: {Name} \nExits: \n";
      foreach (var Connection in Exits)
      {
        template += "\t" + Connection.Value + " - " + Connection.Value.Name;
      }
      return template;
    }
    public Room(string code, string name, string item, string description, string exits)
    {

      Name = name;
      Items = Items;
      Description = description;
      // Exits = exits; 


      Exits = new Dictionary<string, IRoom>();
    }
  }
}