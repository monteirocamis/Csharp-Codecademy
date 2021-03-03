static string Yell(string phrase) 
{
  return phrase.ToUpper();
}
 
public static void Main()
{
  string output = Yell("who's there?");
  Console.WriteLine(output); // Prints WHO'S THERE?
}
