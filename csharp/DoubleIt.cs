using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number, and I will double it!");
    string stringNumber = Console.ReadLine();
    int yourNumber = int.Parse(stringNumber);
    int yourDoubledNumber = yourNumber * 2;
    string stringDoubledNumber = yourDoubledNumber.ToString();
    Console.WriteLine("Your number doubled is " + stringDoubledNumber + "!");
  }
}
