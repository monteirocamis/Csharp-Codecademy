//example:
int number;
bool success = Int32.TryParse("10602", out number); 
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);
// number2 is null and success2 is false

//exercicio :
using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      
      int ageAsInt;
      bool outcome;
      outcome = Int32.TryParse(ageAsString, out ageAsInt)  ;
  
    Console.WriteLine(outcome);
       Console.WriteLine(ageAsInt);

  int nameAsInt;
  bool outcome2;
  outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

  Console.WriteLine(outcome2 );
    Console.WriteLine(nameAsInt );

    }    
	}
}


//outros exemplos:
static string Yell(string phrase, out bool wasYellCalled)
{
  wasYellCalled = true;
  return phrase.ToUpper();
}

// eusing System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
   
      string grito = "GARRRR";
			string murmur = Whisper(grito, out bool marker);
      Console.WriteLine(murmur);
    }    
      static string Whisper(string phrase, out bool buleana)
      {
        buleana = true;
    return phrase.ToLower();
      }
  
	}
}
