/*
examples:
int[] plantHeights = { 3, 4, 6 };
 
// arrayLength will be 3
int arrayLength = plantHeights.Length 
*/

//exercise


using System;

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito" };

if(summerStrut.Length == 8){
Console.WriteLine("summerStrut Playlist is ready to go!");
}
else if( summerStrut.Length > 8)
{
  Console.WriteLine("Too many songs!");
}
else
{
 Console.WriteLine("Add some songs!");
}


    
    }
  }
}

