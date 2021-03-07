/*exemplos
Array.IndexOf()

int[] plantHeights = { 3, 6, 4, 1, 6, 8 };
 
 // returns 1
Array.IndexOf(plantHeights, 6);

Array.Find()

*/
using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

   int positioned = Array.IndexOf(ratings, 3);
  Console.WriteLine($"Song number {positioned + 1} is rated three stars");

string firstBigSong = Array.Find(summerStrut,findBig => findBig.Length > 10 );
Console.WriteLine($"The first song that has more than 10 characters in the title is {firstBigSong}.");


Array.Sort(summerStrut);
Console.WriteLine($" {summerStrut[0] } and {summerStrut[7]}");
    }
  }
}
