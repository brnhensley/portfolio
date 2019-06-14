using System;

class FirstLetterChecker
{
  static void Main()
  {
    Console.WriteLine("What is yo name?");
    string userName = Console.ReadLine().ToUpper();
    if (userName.StartsWith("Z"))
    {
      Console.WriteLine("Your name starts with Z!");
    }
    else
    {
      Console.WriteLine("Yo name don't start with Z!");
    }
  }
}
