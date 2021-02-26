*/ string color;
 
switch (color)
{
   case "blue":
      // execute if the value of color is "blue"
      Console.WriteLine("color is blue");
      break;
   case "red":
      // execute if the value of color is "red"
      Console.WriteLine("color is red");
      break;
   case "green":
      // execute if the value of color is "green"
      Console.WriteLine("color is green");
      break;
   default:
      // execute if none of the above conditions are met
      break;
}

When using a switch statement, make sure to pay attention to:

    Cases: rather than writing out each condition, if we’re evaluating one value we use cases to specify different potential values.
    Braces: rather than each case having its own code block, the entire statement lives within one set of braces {}.
    Colons: to distinguish between different cases, we state the case value, followed by a colon :. The code that should execute if that case is met follows.
    Break: Each case code needs to end with a break keyword.
    Default: Every switch statement needs a default case.

*/
using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Choose a movie genre: ");
      string genre = Console.ReadLine();

      switch (genre)
      {
        case "Drama":
          Console.WriteLine("Citizen Kane");
        break;

        case "Comedy":
          Console.WriteLine("Duck Soup");
        break;

        case "Adventure":
          Console.WriteLine("King Kong");
        break;

        case "Horror":
          Console.WriteLine("Psycho");
        break;

        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
        break;

        default:
          Console.WriteLine("No movie found");
        break;
      }

    }
  }
}
