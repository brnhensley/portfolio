using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'N' for no]");
    string answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
      AddContact();
    }
    else
    {
      Console.WriteLine("Would you like to lookup a number in your phone book? ['Y' for yes, 'N' for no]");
      string lookUpAnswer = Console.ReadLine().ToUpper();
      if (lookUpAnswer == "Y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished with this program? ['Y' for yes, 'N' for no]");
        string finishedAnswer = Console.ReadLine().ToUpper();
        if (finishedAnswer == "Y")
        {
          Console.WriteLine("Goodbye");
        }
        else
        {
          Main();
        }
      }
    }
  }

  static void AddContact()
  {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contact's name");
    string name = Console.ReadLine().ToUpper();
    Console.WriteLine("Enter a new contact's phone number");
    string number = Console.ReadLine();
    if (phoneNumbers.ContainsKey(name))
    {
      Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
    }
    else
    {
      phoneNumbers.Add(name, number);
    }
    Main();
  }

  static void LookUpContact()
  {
    Console.WriteLine("CONTACT LOOKUP");
    Console.WriteLine("Whose number do you want?");
    string friend = Console.ReadLine().ToUpper();
    if (phoneNumbers.ContainsKey(friend))
    {
      string value = phoneNumbers[friend];
      Console.WriteLine(friend + "\'s phone number is " + value);
    }
    else
    {
      Console.WriteLine("That person isn't in your phone book.");
    }
    Main();
  }
}
