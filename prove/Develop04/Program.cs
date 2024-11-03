using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool done = false;
        while (!done)
        {
            BreathingActivity BreathAct1 = new();
            BreathAct1.Init();
            Console.Clear();
            Console.WriteLine("continue [Y/n]?");
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