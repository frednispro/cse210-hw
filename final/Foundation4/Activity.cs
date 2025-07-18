using System;

public abstract class Activity
{
    protected DateTime Date;
    protected double LengthInMinutes;  // duration of activity

    public Activity(DateTime date, double lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();  // in miles or km depending on activity
    public abstract double GetSpeed();     // in mph or kph
    public abstract double GetPace();      // minutes per mile or km

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} - {this.GetType().Name}: " +
               $"Distance: {GetDistance():F2}, Speed: {GetSpeed():F2}, Pace: {GetPace():F2} min/unit, Duration: {LengthInMinutes} min";
    }
}
