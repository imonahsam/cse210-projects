using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String valueFromUser = Console.ReadLine();
        int x = int.Parse(valueFromUser);

        String letter = " ";
        

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else if (x <= 60)
        {
            letter = "F";
        }

        // Determine if the user pass or not
        if (x >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Don't worry, keep working hard for next time");
        }

        // Determine the sign (+, -, or none)

        int lastDigit = (int)(x % 10);
        String sign = " ";
        
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Display the letter grade
        Console.WriteLine($"Your grade letter is: {letter}{sign}");
    }
}