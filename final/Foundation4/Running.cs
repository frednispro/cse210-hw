using System;

public class Running : Activity
{
    private double DistanceMiles;

    public Running(DateTime date, double lengthInMinutes, double distanceMiles)
        : base(date, lengthInMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return DistanceMiles;
    }

    public override double GetSpeed()
    {
        return DistanceMiles / (LengthInMinutes / 60);  // mph
    }

    public override double GetPace()
    {
        return LengthInMinutes / DistanceMiles;  // minutes per mile
    }
}
