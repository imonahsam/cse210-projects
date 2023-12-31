using System;

public class ReceptionEvent : Event
{
    private string _rsvpEmail;
    
    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}