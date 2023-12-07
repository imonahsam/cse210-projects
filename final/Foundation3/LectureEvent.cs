using System;

public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
       _speakerName = speakerName;
       _capacity = capacity; 
    }
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Lecture\nSpeakerName: {_speakerName}\nCapacity: {_capacity}";
    }
}