using System;


public class PromptGenerator
{
    public string[] prompts;
    public List<string> _prompts = new List<string>();

    public void StorePrompts()
    {
        _prompts.Add("Who was the most intersting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("Did you watched a TV show today? If so what is it?");      
    }

    public void AddPrompt(string prompts)
    {
        _prompts.Add(prompts);
        Console.WriteLine("Your prompt has been added to the prompt list.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }

    public void printPrompt()
    {
        foreach(string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}