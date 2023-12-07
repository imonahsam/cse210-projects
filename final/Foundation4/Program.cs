using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>
        {
            new Running(new DateTime(2023, 11, 28), 30, 3.0),
            new Running(new DateTime(2023, 11, 29), 30, 4.8),
            new Cycling(new DateTime(2023, 11, 29), 30, 9.7),
            new Swimming(new DateTime(2023, 11, 30), 30, 2),
        };

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}