/*
while (playerIsAlive) 
{ 
// this code will keep running
 
  if (playerIsAlive == false) 
  { 
    // eventually if this stopping condition is true, 
    // it will break out of the while loop
    break; 
   } 
 } 
 
// rest of the program will continue

//outro exemplo:
int bats = 10;
 
for (int i = 0; i <= 10; i++)
{
  if (i < 9)
  {  
    continue;
  }
  // this will be skipped until i is no longer less than 9
  Console.WriteLine(i);
}

//exemplo:
int bats = 10;
 
for (int i = 0; i <= 10; i++)
{
  if (i < 9)
  {  
    continue;
  }
  // this will be skipped until i is no longer less than 9
  Console.WriteLine(i); // nothing will print to the console until i is equal to 9.
}

// ***mais exemplos:
class MainClass {
 public static void Main (string[] args) {
   UnlockDoor();
 
  // after it hits the return statement, it will move on to this method
   PickUpSword();
 }
 
 static bool UnlockDoor()
 {
   bool doorIsLocked = true;
 
   // this code will keep running
   while (doorIsLocked)
   {
     bool keyFound = TryKey();
 
      // eventually if this stopping condition is true,
      // it will break out of the while loop
     if (keyFound)
     {
      // this return statement will break out of the entire method
      return true;
     }
   }
   return false;
 }
}



You should only use return if you need to exit a method, because it will break out of all loops. If you only want to break out of one loop and not exit a method, use break. 
*/

using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = false;
      int trackeando = 0;
      do{
        Console.WriteLine("BLARRRRR");
        trackeando++;
         if(trackeando == 3){
       break;
     }
 } 
   while(!buttonClick);

    }
  }
}


