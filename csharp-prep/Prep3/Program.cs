using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    
    {
       //int magicNumber;
       //Console.Write("What is the magic number? ");
       //int magicNumber = int.Parse(Console.ReadLine());

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);        
       int guess = -1;


       do
       {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
            }

       } while (guess != magicNumber);

    }

}