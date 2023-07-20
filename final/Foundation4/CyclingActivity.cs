public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _lengthInMinutes;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
