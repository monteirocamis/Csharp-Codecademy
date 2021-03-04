static string Yell(string phrase) 
{
  return phrase.ToUpper();
}
 
public static void Main()
{
  string output = Yell("who's there?");
  Console.WriteLine(output); // Prints WHO'S THERE?
}

//exercicio return:
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
//exercicio return errors:

using System;

namespace ReturnErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Mars")); 
      Console.WriteLine("Is Pluto really a dwarf...?");
      Console.WriteLine(IsPlutoADwarf());
      Console.WriteLine("Then how many planets are there in the galaxy...?");
      Console.WriteLine(CountThePlanets());
    }
    
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    static bool IsPlutoADwarf()
    {
      bool answer = true;
      return answer ;
    }
    
    static string CountThePlanets()
    {
      return "8 planets, usually";
    }
	}
}
