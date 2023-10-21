using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _text; // Add a field to store the original text.

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _text = text; // Store the original text.
        string[] words = text.Split(" ");
        foreach (string wd in words)
        {
            _words.Add(new Word(wd));
        }
    }

    public string GetText()
    {
        return _text; // Return the stored original text.
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            Word wordToHide = _words[randomIndex];

            if (!wordToHide.IsHidden())
            {
                wordToHide.Hide();
                hiddenCount += 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = ""; // Initialize as an empty string.
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText + " ";
        }

        return $"{_reference.GetDisplayText()} {displayText.Trim()}";
    }

    public bool IsHiddenCompletely()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
