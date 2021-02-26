*/ Logical operators include:

    AND &&: Both expressions are evaluated and will return True only if both expressions evaluate to True. Otherwise, it will return False.
    OR ||: Both expressions are evaluated and will return True if at least one of the expressions evaluates to True. Otherwise, it will return False.
    NOT !: An expression, no matter its logical value, evaluates to its opposite. What is True becomes False and what is False becomes True.  
    */


using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

bool yourNeeds = ( beach && city) ;
bool friendNeeds = ( beach || hiking);
bool tripDecision = (yourNeeds && friendNeeds);

Console.WriteLine(tripDecision );
    }
  }
}


