/* Comparison operators include:

    Equals ==: returns true if the value to the left is equal to the value to the right.
    Inequality operator !=: returns true if the two values are not equal.
    Less than <: returns true if the value to the left is less than the value to the right.
    Greater than >: returns true if the value to the left is more than the value to the right.
    Less than or equal to <=: returns true if the value to the left is less than or equal to the value on the right.
    Greater than or equal to >=: returns true if the value to the left is more than or equal to the value to the right.
*/

using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {

double timeToDinner = 4;

double distance = 95;
double rate = 30;

double tripDuration = distance / rate;

bool answer = tripDuration  <= timeToDinner;

Console.WriteLine(answer);
    }
  }
}
