using System;

class Program
{
    static void Main(string[] args)
    {
        int user = -1;
        while (user != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Choices:");
            Console.Write("1. Start Breathing Activity\n2. Start the Reflection Activity\n3. Start Listing Activity\n4. Quit\nPlease make your choice from the menu: ");
            string input = Console.ReadLine();
            int choice;
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    string breathe = "Breathing Activity";
                    string breatheDescrip = "This activity will help you relax by walking you through breathing in and out slowly. Please clear your mind and focus on your breathing.";
                    BreathingActivity breath = new BreathingActivity(breathe, breatheDescrip);
                    breath.DisplayStartingMessage();
                    breath.Run();
                    breath.DisplayEndingMessage();
                    breath.ShowSpinner(5);
                }
                else if (choice == 2)
                {
                    string reflect = "Reflection Activity";
                    string reflectDescrip = "This activity will help you reflect on times in your life when you need to show strength and resilience. This will help you recognize the power that you have and how you can use it in other areas of your life.";
                    ReflectingActivity refl = new ReflectingActivity(reflect, reflectDescrip);
                    refl.StorePrompt();
                    refl.StoreRandomQuestion();
                    refl.DisplayStartingMessage();
                    refl.Run();
                    refl.DisplayEndingMessage();
                    refl.ShowSpinner(5);
                }
                else if (choice == 3)
                {
                    string listName = "Listing Activity";
                    string listDescrip = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
                    ListingActivity list = new ListingActivity(listName, listDescrip);
                    list.StorePrompt();
                    list.DisplayStartingMessage();
                    list.Run();
                    list.DisplayEndingMessage();
                    list.ShowSpinner(5);
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
