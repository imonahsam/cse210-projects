using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promGen = new PromptGenerator();
        promGen.StorePrompts();

        Console.WriteLine("Welcome to your Journal!");
        
        int userInput = -1;    
        while (!(userInput == 6))
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Add personal prompt to prompt list");
            Console.WriteLine("6. Exit");
            Console.Write("\nWhat would you like to do today? ");


            string input = Console.ReadLine();
            int choice = int.Parse(input);

            if (choice == 1)
            {
                
                Entry anEntry = new Entry();
                string newPrompt = promGen.GetRandomPrompt();
                Console.WriteLine(newPrompt);
                anEntry._promptText = newPrompt;
                DateTime date = DateTime.Now;
                string currentDate = date.ToLongDateString();
                string currentTime = date.ToLongTimeString();
                anEntry._date = currentDate;
                anEntry._time = currentTime;
                Console.Write("\nWrite Here Please: ");
                string userEntry = Console.ReadLine();
                anEntry._entryText = userEntry;
                journal.AddEntry(anEntry);
            }
            else if(choice == 2)
            {
                journal.DisplayAll();
            }
            else if(choice == 3)
            {
                Console.Write("Enter the file name to save to: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
                Console.WriteLine("Journal saved to file.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter the file name to load from: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
                Console.WriteLine("Journal loaded from file.");
            }
            else if (choice == 5)
            {
                Console.Write("\nWrite a prompt here: ");
                string userPrompt = Console.ReadLine();
                promGen.AddPrompt(userPrompt);
            }
            else if (choice == 6)
            {
                break;
            }           
        } 
    }
}