using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }
    public void AddComment(string commenterName, string commenterText)
    {
        Comment _comment = new Comment(commenterName, commenterText);
        _comments.Add(_comment);
    }
    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthSeconds}");
        Console.WriteLine($"Number of Comments: {GetNumComments()}");
        if (GetNumComments() > 0)
        {
            Console.WriteLine("Comments:");
            foreach (Comment _comment in _comments)
            {
                Console.WriteLine($"- {_comment._commentName}: {_comment._commentText}");
            }
        }
        Console.WriteLine("\n");
    }
}