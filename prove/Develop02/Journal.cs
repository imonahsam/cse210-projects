using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Your Entry has been added to the Journal");
    }

    public void DisplayAll()
    {
        for(int i=0; i<_entries.Count; i++)
        {
            Entry entry = _entries[i];
            entry.Display();
        }
        Console.WriteLine("\nIncrease your console size to get the best view");
    }

    public void SaveToFile(string file)
    {
        string fileContent = "";
        foreach (Entry entry in _entries)
        {
            fileContent += $"\nDate: {entry._date}\nTime: {entry._time}\n";
            fileContent += $"Prompt: {entry._promptText}\nEntry: {entry._entryText}\n";
        }
        File.AppendAllText(file, fileContent);
        Console.WriteLine("Your file has been saved.");
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("\nIncrease your console size to get the best view");
    }
}

