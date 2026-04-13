using System;

public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int length)
    {
        _date = date;
        _lengthInMinutes = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} ({_lengthInMinutes} min) - " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} kph, " +
               $"Pace: {GetPace():0.00} min/km";
    }
}