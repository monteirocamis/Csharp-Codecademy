using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program  we’ll use C# to write a Mad Libs word game! Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story. 
      Author: Camis Monteiro by Codecademy
      */


      // Let the user know that the program is starting:
  Console.WriteLine("Mad Libs começou!");

      // Give the Mad Lib a title:
      string title = "titulo";

      Console.WriteLine(title);
 Console.WriteLine("\n");
      // Define user input and variables:
         Console.WriteLine("Insira um nome para o personagem principal:");
    string MainCharacter = Console.ReadLine();
    Console.WriteLine("\n");

        Console.WriteLine("Insira um adjetivo: ");
    string adjective1 = Console.ReadLine();
    Console.WriteLine("\n");


        Console.WriteLine(" Insira um segundo adjetivo: ");
    string adjective2 = Console.ReadLine();
    Console.WriteLine("\n");

        Console.WriteLine("Insira um terceiro adjetivo: ");
    string adjective3 = Console.ReadLine();
    Console.WriteLine("\n");

    
      // The template for the story:

      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}
