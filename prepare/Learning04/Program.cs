using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Doe", "History");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Brown Smith", "Multiplication", "8.9", "3-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());

        WritingAssignment a3 = new WritingAssignment("John Smith", "History", "The Dawn of Time in Humans");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}