using System;


class Program
{
    private static int GenerateNumber()
    {
        return new Random().Next(1, 101);
    }

    private static int CollectGuess()
    {
        int guess;
        do
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int guessTemp) || guessTemp < 1 || guessTemp > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            else
            {
                guess = guessTemp;
                return guess;
            }
        } while (true);
    }

    private static int GuessingGame()
    {
        bool again = true;
        int attemptCount = 0;
        int correctVal = GenerateNumber();
        Console.WriteLine("Welcome to the guessing game!");
        Console.Write("Guess a number between 1 and 100. ");
        while (again)
        {
            int currentGuess = CollectGuess();
            if (currentGuess == correctVal)
            {
                Console.WriteLine("You guessed correctly!");
                again = false;
            }
            else if (currentGuess < correctVal)
            {
                Console.Write("Too low. Try again. ");
                attemptCount++;
            }
            else
            {
                Console.Write("Too high. Try again. ");
                attemptCount++;
            }
        }
        return attemptCount;

    }
    static void Main(string[] args)
    {
        bool again = true;
        while (again)
        {
            int attempts = GuessingGame();
            Console.WriteLine($"It took you {attempts} trys to guess the answer. Do you want to continue? (Y/n)");
            string input = Console.ReadLine();
            if (input == "n")
            {
                again = false;
            }
        }
    }
}