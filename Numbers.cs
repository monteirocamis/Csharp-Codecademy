using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      DATA TYPES: int, double
      ARITHMETIC OPERATORS: +, -, *, /
      INCREMENT/DECREMENT: ++, --
      MODULO: % 
      BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

      Good luck! */


      //Console.WriteLine(" Insert your Revenue from last month:")
     // Console.ReadLine() = double revenue;
     double revenue = 2000.50;
      int cost = 800;

      Console.WriteLine(Math.Floor(revenue - cost));


    }
  }
}
