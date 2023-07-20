using System;

public class Activity
{
    protected DateTime _date;
    protected int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base implementation, to be overridden in derived classes.
    }

    public virtual double GetSpeed()
    {
        return 0; // Base implementation, to be overridden in derived classes.
    }

    public virtual double GetPace()
    {
        return 0; // Base implementation, to be overridden in derived classes.
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string activityType = GetType().Name;

        return $"{_date:dd MMM yyyy} {activityType} ({_lengthInMinutes} min): Distance {distance:F1} km, Speed: {speed:F1} kph, Pace: {pace:F1} min per km";
    }
}
