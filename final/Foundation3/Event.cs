using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetRateStandardDetails()
    {
        return $"Standard Details: \nTitle: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFormattedAddress()}";
    }
    public string GenerateShortDescription()
    {
        return $"Short Description:\nType: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }

    public virtual string GenerateFullDetails()
    {
        return GetRateStandardDetails();
    }
}