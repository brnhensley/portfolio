using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "farts", "bread", "bananas", "cereal", "rice", "yogurt"};

    Console.WriteLine("My grocery list:");
    for (int i = 0; i < myGroceryList.Length; index++)
    {
      Console.WriteLine(myGroceryList[i]);
    }

    int[] groceryListPrices = { 6, 8, 3, 6, 0, 2, 1, 9};
    int total = 0;
    foreach (int price in groceryListPrices)
    {
        total = total + price;
        // total += price;
    }
    Console.WriteLine("Your total is $" + total);
  }
}
