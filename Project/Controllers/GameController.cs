using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project.Controllers
{

  public class GameController : IGameController
  {
    private GameService _gameService = new GameService();

    //NOTE Makes sure everything is called to finish Setup and Starts the Game loop
    public void Run()
    {
      while (true)
      {
        Run();
        GetUserInput();
      }
    }

    //NOTE Gets the user input, calls the appropriate command, and passes on the option if needed.
    public void GetUserInput()
    {
      Console.WriteLine("What would you like to do?");
      string input = Console.ReadLine().ToLower() + " ";
      string command = input.Substring(0, input.IndexOf(" "));
      string option = input.Substring(input.IndexOf(" ") + 1).Trim();
      //NOTE this will take the user input and parse it into a command and option.
      //IE: take silver key => command = "take" option = "silver key"

    }

    //NOTE this should print your messages for the game.
    private void Print()
    {
      System.Console.WriteLine("What would you like to do");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "quite":
          _gameService.Quit();
          break;
        case "look":
          _gameService.Look();
          break;
        case "get item":
          _gameService.TakeItem(input);
          break;
        case "use item":
          _gameService.UseItem(input);
          break;
        case "move":
          _gameService.Go(input);
          break;
        case "help":
          _gameService.Help();
          break;
      }
    }
  }
}