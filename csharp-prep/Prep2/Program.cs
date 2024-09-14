using System;

class Program
{
    private static string AssignLetterGrade(int grade)
    {
        if (grade < 60)
        {
            return "F";
        }
        else if (grade < 70)
        {
            return "D";
        }
        else if (grade < 80)
        {
            return "C";
        }
        else if (grade < 90)
        {
            return "B";
        }
        else
        {
            return "A";
        }
    }
    private static string AppendLetterModifier(int grade, string letterGrade)
    {
        if (grade == 100)
        {
            // in this case, no appending is necessary
            return letterGrade;
        }
        else if (letterGrade == "F")
        {
            // specs say no F- or F+
            return letterGrade;
        }
        else if (grade >= 97)
        {
            // specs say no A+
            return letterGrade;
        }
        else if (grade % 10 >= 7)
        {
            return letterGrade + "+";
        }
        else if (grade % 10 < 3)
        {
            return letterGrade + "-";
        }
        else
        {
            return letterGrade;
        }
    }
    static void Main(string[] args)
    {
        bool again = true;
        while (again)
        {
            Console.Write("Enter a  numeric grade between 0 & 100 inclusive: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Please enter a grade between 0 & 100 inclusive.");
                continue;
            }
            string letterGrade = AssignLetterGrade(grade);
            letterGrade = AppendLetterModifier(grade, letterGrade);
            Console.WriteLine($"The letter grade is {letterGrade}");
            Console.WriteLine($"This grade is a {(grade < 70 ? "fail" : "pass")}.");
            Console.Write("Would you like to enter another grade? (y/n) ");
            string response = Console.ReadLine();
            if (response == "n")
            {
                again = false;
            }
            else
            {
                Console.Write("\n");
            }
        }
    }
}