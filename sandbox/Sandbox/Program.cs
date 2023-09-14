using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#");

       Console.Write("What is your first name? ");
       String firstname = Console.ReadLine();
       Console.Write("What is your last name? ");
       String lastname = Console.ReadLine();
       Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");

    }
}