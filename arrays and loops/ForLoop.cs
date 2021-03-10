/*
for (initialization; stopping condition; iteration statement)
{
  statement;
}

These expressions are:

    Initialization: where the loop begins
    Stopping condition: the condition that the iterator variable is evaluated against
    Iteration statement: used to update the iterator variable on each loop

*/

using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    { 
        for (int i = 1; i < 17; i++){
CreateTemplate(i);
}

    }
    
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
  
    
    
  }
}
