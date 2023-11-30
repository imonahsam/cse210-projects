using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "CSharpMaster", 350);
        video1.AddComment("Coder321", "Great tutorial!");
        video1.AddComment("ProgrammingNewbie", "I learned a lot!");
        video1.AddComment("Instructor", "Great Job!");

        Video video2 = new Video("Data Structures in C#", "DataStructuresPro", 450);
        video2.AddComment("DataGeek", "Excellent explanation!");
        video2.AddComment("CSharpEnthusiast", "Very informative!");
        video2.AddComment("Programmer", "Nice Code!");

        Video video3 = new Video("Web Development with ASP.NET", "WebDevelopmentExpert", 580);
        video3.AddComment("WebEnthusiast", "Awesome content!");
        video3.AddComment("CodeExplorer", "Thanks for the tips!");
        video3.AddComment("WebDesigner", "Looks good!");

        List<Video> _videoList = new List<Video> {video1, video2, video3};

        foreach (Video _video in _videoList)
        {
            _video.DisplayVideoInfo();
        }
    }
}