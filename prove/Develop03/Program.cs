using System;

class Program
{
  static void Main(string[] args)
  {
    // Hi Jacob, here's what I did to hit the "creativity and exceeding requirments" part of the rubric:
    // I added a built-in scripture option. The user can type "b" to get a random built-in scripture rather than type in their own.
    // also, i'm checking for the randomly hidden word to not already be a target for hiding.
    bool done = false;
    Console.WriteLine("welcome to scripture memorizer");
    // i've moved the logic for getting a scripture (either from a user or from a built-in list) into the ScriptureGetter class. look there for instantiation of Reference and Scripture objects.
    Scripture currentScripture = ScriptureGetter.GetScripture();
    Console.Clear();
    Console.WriteLine("Your current scripture:");
    while (!done)
    {
      currentScripture.DisplayScripture();
      string response = Console.ReadLine();
      if (response == "\n" || response == "\r\n" || response == "\r" || response == "")
      {
        if (currentScripture.AllHidden())
        {
          Console.WriteLine("You have hidden all the words!");
          done = true;
          continue;
        }
        currentScripture.HideAWord();
        Console.Write("you hit enter");
        Console.Clear();
        continue;
      }
      else if (response == "q")
      {
        done = true;
        continue;
      }
      else
      {
        Console.WriteLine("Invalid response");
        continue;
      }
    }
  }
}