using System;

public class Swimming : Activity
{
    private int NumberOfLaps;
    private double PoolLengthMeters;

    public Swimming(DateTime date, double lengthInMinutes, int numberOfLaps, double poolLengthMeters)
        : base(date, lengthInMinutes)
    {
        NumberOfLaps = numberOfLaps;
        PoolLengthMeters = poolLengthMeters;
    }

    public override double GetDistance()
    {
        // convert meters to miles (1 mile = 1609.34 m)
        double distanceMeters = NumberOfLaps * PoolLengthMeters;
        return distanceMeters / 1609.34;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthInMinutes / 60);
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }
}
