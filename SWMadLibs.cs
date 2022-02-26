// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace SWMadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      var secDelayThree = 3000;
      var secDelayOne = 1000;

      // Let the user know that the program is starting:
      Console.WriteLine("Loading...");
      Thread.Sleep(secDelayThree);

      // Give the Mad Lib a title:
      string? title = "Star Wars MadLibs! We're going to gather some words and mash them up into what could definitely be a scene from a Star Wars movie!";
      Console.WriteLine(title);
      Thread.Sleep(secDelayThree);

      Console.WriteLine("Are you ready? Type Y for yes, N for no...");
      string? ready = Console.ReadLine();
      if(ready == "Y") {
        Console.WriteLine("Great, let's get to it!");
      } else if(ready == "N") {
        Console.WriteLine("Not to worry, look forward to maybe seeing you again soon!");
        Thread.Sleep(secDelayOne);
        Environment.Exit(0);
      }

      Thread.Sleep(secDelayOne);

      // Define user input and variables:
      Console.Write("\nWho is your favourite force user? ");
      string? name = Console.ReadLine();
      Console.Write("Good choice...\n");

      Thread.Sleep(secDelayOne);

      Console.Write("We're going to need some adjectives\n");
      Console.Write("Adjective 1: > ");
      string? adj1 = Console.ReadLine();

      Console.Write("Adjective 2: > ");
      string? adj2 = Console.ReadLine();

      Console.Write("Finally, adjective 3: > ");
      string? adj3 = Console.ReadLine();

      Console.Write("I need a verb now: > ");
      string? verb = Console.ReadLine();

      Console.Write("Now we need some nouns, 2 to be exact...\n");
      Console.Write("Noun 1: > ");
      string? noun1 = Console.ReadLine();

      Console.Write("Noun 2: > ");
      string? noun2 = Console.ReadLine();

      Console.Write("\nNow for some random stuff...\n");
      Console.Write("Favourite animal in the Start Wars universe? > ");
      string? faveAnimal = Console.ReadLine();

      Console.Write("Your favourite food? > ");
      string? faveFood = Console.ReadLine();

      Console.Write("Favourite Sith Lord: > ");
      string? faveSith = Console.ReadLine();
      Console.Write("Formidable!\n");

      Thread.Sleep(secDelayOne);

      Console.Write("Favourite planet: > ");
      string? favePlanet = Console.ReadLine();

      Console.Write("Favourite pudding: > ");
      string? favePudding = Console.ReadLine();

      Console.Write("Favourite era in the Star Wars universe: > ");
      string? faveEra = Console.ReadLine();

      // The template for the story:
      Console.WriteLine("Putting the masterpiece together...");
      Thread.Sleep(secDelayThree);

      string story = $" \nThis morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!'. Outside, a bunch of {faveAnimal}s were protesting to keep {faveFood} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {noun2}s very {adj3}. Concerned, {name} texted {faveSith}, who flew {name} to {favePlanet} and dropped {name} in a puddle of frozen {favePudding}. {name} woke up in the {faveEra} era, on a planet where {faveAnimal}s ruled.\n";
      
      // Print the story:
      Console.WriteLine(story);
    }
  }
}