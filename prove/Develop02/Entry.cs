using System;

public class Entry
{
    public string _date;
    public string _time;
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}\nTime: {_time}\nPrompt: {_promptText}\nEntry: {_entryText}");
    }
}