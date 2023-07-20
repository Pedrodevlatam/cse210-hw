public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_lengthInMinutes / 60);
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}
