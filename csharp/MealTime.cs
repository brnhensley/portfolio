using System;

class MealTime
{

  static void Main()
  {
    AskWhatYouAteFor("breakfast");
    AskWhatYouAteFor("lunch");
    AskWhatYouAteFor("dinner");
  }

  //  'string meal' creates a variable of whatever the input is to the arguement - breakfast, lunch or dinner
  static void AskWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string yourMeal = Console.ReadLine();
    Console.WriteLine("You had " + yourMeal + " for " + meal + ".");
  }
}
