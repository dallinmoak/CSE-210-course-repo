using System;

class Program
{
    void GenerateMenu()
    {
        Console.WriteLine("Welcome to the Breathing Activity Program!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Exit");
    }
    static void Main(string[] args)
    {
        Console.Clear();
        bool done = false;
        while (!done)
        {
            BreathingActivity BreathAct1 = new();
            BreathAct1.Init();

            Console.WriteLine("again? [Y/n]?");
            string choice = Console.ReadLine();
            if (choice == "n")
            {
                done = true;
            }
            else
            {
                done = false;
            }
            Console.Clear();
        }
    }
}