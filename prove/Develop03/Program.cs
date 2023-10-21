using System;


public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine($"Please make a choice of the Scripture below:");
        Console.Write("1.Genesis 1:26-27 \n2.John 14:14\n3.Proverbs 3:5-6\nPlease enter your choice: ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        if (choice == 1)
        {
            Reference f1 = new Reference("Genesis", 1,26,27);
            string scriptureText = ("And God said, Let us make man in our image, after our likeness: and let them have dominion" +
            " over the fish of the sea, over the fowl of the air, and over the cattle, and over all the earth, and over every" +
            " creeping thing that creepth upon the earth. So God created man in his own image, in the image of God created he him;" +
            " male and female created he them.");
            Scripture scripture = new Scripture(f1, scriptureText);

            string response;
            do
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nPlease type 'ENTER' to hide words or type 'QUIT' to quit: ");
                response = Console.ReadLine();

                if(!(scripture.IsHiddenCompletely()))
                {
                    scripture.HideRandomWords(2);
                    Console.WriteLine("\n" + scripture.GetDisplayText());
                    Console.Clear();
                }
                else if (scripture.IsHiddenCompletely())
                {
                    break;
                }
        } while (!(response == "quit" || response == "QUIT"));
        }
        else if (choice == 2)
        {
            Reference f2 = new Reference("John", 14, 14);
            string scriptureText = ("If ye shall ask any thing in my name, I will do it.");
            Scripture scripture = new Scripture(f2, scriptureText);

            string response;
            do
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nPlease type 'ENTER' to hide words or type 'QUIT' to quit: ");
                response = Console.ReadLine();

                if(!(scripture.IsHiddenCompletely()))
                {
                    scripture.HideRandomWords(2);
                    Console.WriteLine("\n" + scripture.GetDisplayText());
                    Console.Clear();
                }
                else if (scripture.IsHiddenCompletely())
                {
                    break;
                }
        } while (!(response == "quit" || response == "QUIT"));
        }
        else if (choice == 3)
        {
            Reference f3 = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = ("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all" +
            " thy ways acknowledge him, and he shall direct thy paths.");
            Scripture scripture = new Scripture(f3, scriptureText);

            string response;
            do
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nPlease type 'ENTER' to hide words or type 'QUIT' to quit: ");
                response = Console.ReadLine();

                if(!(scripture.IsHiddenCompletely()))
                {
                    scripture.HideRandomWords(2);
                    Console.WriteLine("\n" + scripture.GetDisplayText());
                    Console.Clear();
                }
                else if (scripture.IsHiddenCompletely())
                {
                    break;
                }
        } while (!(response == "quit" || response == "QUIT"));
        }
        else
        {
            Console.WriteLine("Please restart and make your choice from the available scriptures.");
        }
    }
}    