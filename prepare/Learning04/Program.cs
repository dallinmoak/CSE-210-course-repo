using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAss1 = new MathAssignment("Jane Doe", "Algebra", "3", "1-20");
        Console.WriteLine(mathAss1.GetSummary());
        Console.WriteLine(mathAss1.GetHomeworkList());
        WritingAssignment writingAss1 = new WritingAssignment("John Doe", "Poetry", "An Analysis of the Raven");
        Console.WriteLine(writingAss1.GetSummary());
        Console.WriteLine(writingAss1.GetWritingInformation());
    }
}