using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
VisitPlanets(numberOfPlanets : 2,name: "camis ");
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "camis", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}
