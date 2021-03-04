static string Yell(string phrase) 
{
  return phrase.ToUpper();
}
 
public static void Main()
{
  string output = Yell("who's there?");
  Console.WriteLine(output); // Prints WHO'S THERE?
}

//exercicio:
using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
    Console.WriteLine( DecoratePlanet("Jupiter"))  ;
    }
     static string DecoratePlanet(string planet) {
      return ($"*.*.* Welcome to {planet} *.*.*");
    }
	}
}
