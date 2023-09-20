using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    //int userInput;
    
    {
        int userNumber = -1;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            
            Console.Write("Enter a Number ");

            string userResponse = Console.ReadLine();

            userNumber = int.Parse(userResponse);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float ave = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {ave}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
       
        
    }
}