using System;
using System.Collections.Generic;

public class Comment
{
    public string _commentName;
    public string _commentText;

    public Comment(string commenterName, string commenterText)
    {
        _commentName = commenterName;
        _commentText = commenterText;
    }
}