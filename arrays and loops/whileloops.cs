/* while (condition) 
{
  statement;
}

while (spacebar == "down") 
{
 RiseUp();
}
*/

using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;  
      
      while (emails > 0) 
{
 emails--;
 Console.WriteLine($"one email deleted and have {emails } left. ");
}

   Console.WriteLine("INBOX ZERO ACHIEVED!");

    }
  }
}

