using System;

class Program
{

    private static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    private static string ProptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    private static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            else
            {
                return number;
            }

        }
    }

    private static int SquareNumber(int number)
    {
        return number * number;
    }

    private static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    static void Main(string[] args)
    {
        bool again = true;
        while (again)
        {
            DisplayWelcome();
            string name = ProptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(name, square);
            Console.WriteLine("again? (Y/n)");
            string input = Console.ReadLine();
            if (input == "n")
            {
                again = false;
            }
        }
    }
}