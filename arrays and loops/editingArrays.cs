/* exemplos
// plantHeights will be equal to [0, 0, 0]
int[] plantHeights = new int[3]; 
 
// plantHeights will now be [0, 0, 8]
plantHeights[2] = 8; 

int[] plantHeights = { 3, 4, 6 };
 
// plantHeights will be [3, 5, 6]
plantHeights[1] = 5; 
*/
//exercicio

using System;

namespace EditingArrays
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
    int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
    summerStrut[7]  = "I Like It";
     ratings[7]  = 5;
    }
  }
}

