using System;

namespace CallAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      string msg = "Yabba dabba doo!";
      Math.Min(2,4);
      Console.WriteLine(msg);
     msg.Substring(0,1);
     

    }
  }
}
//review
using System;

namespace IntroMethodOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      // Call a method with multiple arguments
      NamePets("Laika", "Albert");
      // Call a method with named arguments
      VisitPlanets(numberOfPlanets: 8);
    }
    
    // Define a method with multiple parameters
    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }  
 
    // Define a method with optional parameters
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
    
  }
}
