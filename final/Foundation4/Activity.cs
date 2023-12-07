using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime _date;
    protected int _durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date: dd MMM yyyy} - {GetType().Name} ({_durationMinutes} min)";
    }
}