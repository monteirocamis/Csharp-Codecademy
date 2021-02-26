*/string color = "blue";
string result = (color == "blue") ? "blue" : "NOT blue";
 
Console.WriteLine(result);
*/

using System;

namespace TernaryOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      int pepperLength = 4;

string message = ( pepperLength >= 3.5)? "ready!" : "wait a little longer";
Console.WriteLine(message);

    }
  }
}
