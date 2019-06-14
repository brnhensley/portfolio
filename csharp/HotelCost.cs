using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine().ToLower();

    Console.WriteLine("On the weekend or weekday?");
    string dayOfWeek = Console.ReadLine().ToLower();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
    }
    else if (summer || weekend)
    {
      Console.WriteLine("It will be more expensive than normal.");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("It will be cheap.");
    }
    else
    {
      Console.WriteLine("I don't think the code can ever get here.");
    }
  }
}
