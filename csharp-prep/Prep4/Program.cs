using System;

class Program
{

    private static int CollectNewNumber()
    {
        int number;
        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int numberTemp))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            else
            {
                number = numberTemp;
                return number;
            }
        } while (true);
    }

    public static List<int> CreateList()
    {
        List<int> myList = [];
        bool again = true;
        while (again)
        {
            int number = CollectNewNumber();
            myList.Add(number);
            if (number == 0)
            {
                again = false;
            }
        }
        return myList;
    }
    static void Main(string[] args)
    {
        bool again = true;
        while (again)
        {
            Console.WriteLine("Enter a list of numbers. Enter 0 to finish.");
            List<int> myList = CreateList();
            Console.WriteLine($"The sum is: {myList.Sum()}");
            Console.WriteLine($"The average is: {myList.Average()}");
            Console.WriteLine($"The largest number is: {myList.Max()}");
            Console.WriteLine("again? (Y/n)");
            string input = Console.ReadLine();
            if (input == "n")
            {
                again = false;
            }
        }
    }
}