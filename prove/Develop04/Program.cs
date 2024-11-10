using System;
using System.ComponentModel.Design;

class Program
{
	static int GetMenuChoice()
	{
		bool done = false;
		int option = 0;
		while (!done)
		{
			Console.WriteLine("Menu Options:");
			Console.WriteLine("  1. Start breathing activity");
			Console.WriteLine("  2. Start reflecting activity");
			Console.WriteLine("  3. Start listing activity");
			Console.WriteLine("  4. Quit");
			Console.Write("Select a choice from the menu: ");
			string choice = Console.ReadLine();
			if (int.TryParse(choice, out option) && option >= 1 && option <= 4)
			{
				done = true;
			}
			else
			{
				Console.WriteLine("Invalid choice. Please try again.");
			}
		}
		return option;
	}
	static void Main(string[] args)
	{
		Console.Clear();
		bool done = false;
		while (!done)
		{
			int choice = GetMenuChoice();
			switch (choice)
			{
				case 1:
					new BreathingActivity().Init();
					break;
				case 2:
					new ReflectionActivity().Init();
					break;
				case 3:
					new ListingActivity().Init();
					break;
				case 4:
					done = true;
					break;
				default:
					Console.WriteLine("choice not covered");
					break;
			}
			Console.Clear();
		}
	}
}