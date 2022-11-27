using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter a password :");
      string inputFromUser = Console.ReadLine();

      int minLength = 8;
      string inputWithUppercase = inputFromUser.ToUpper();
      string inputWithLowercase = inputFromUser.ToLower();
      string digits = "1234567890";
      string specialChars = "@!#$%&*()/_+=[]{}?:;-´´`'><.,";
      string space = " ";
     string password = "password";
      string weakNumbers = "1234";



      int score = 0 ; 
        if(inputFromUser.Length >= minLength){
          score++ ;
         Console.WriteLine("minLength"); 
        } 
         if (Tools.Contains(inputFromUser,inputWithUppercase)  ){
          score++ ;
        Console.WriteLine("inputWithUppercase");   
        }
         if (Tools.Contains(inputFromUser,inputWithLowercase) ){
          score++ ;
          Console.WriteLine("inputWithLowercase"); 
        }
         if (Tools.Contains(inputFromUser, digits)){
          score++ ;
           Console.WriteLine("digits"); 
        }
            if (Tools.Contains(inputFromUser, specialChars)){
          score++ ;
          Console.WriteLine("digits"); 
        }
        if(Tools.Contains(inputFromUser, space)){
          score = 0 ;
            Console.WriteLine("space"); 
        } 
      if(inputFromUser == "password"){
          score = 0 ;
             Console.WriteLine("password"); 
        } 
    if(Tools.Contains(inputFromUser, weakNumbers)){
          score = 0 ;
         Console.WriteLine("weakNumbers"); 
        } 

        switch (score)
        {
          case 0:
             Console.WriteLine("password doesn’t meet any of the standards"); 
           break;
          case 1:
            Console.WriteLine("password is weak");
              break;
          case 2 :
            Console.WriteLine("password is medium");
              break;
          case 3 :
            Console.WriteLine("password is strong");
            break;
          case 4 :
           Console.WriteLine("password is extremely strong");
            break;
          case 5 :
           Console.WriteLine("password is extremely strong");
            break;
        
          default:
          break;
        }

    Console.WriteLine(score);
    }
  }
}
