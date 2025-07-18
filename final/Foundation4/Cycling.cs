using System;

public class Cycling : Activity
{
    private double SpeedMph;  // average speed

    public Cycling(DateTime date, double lengthInMinutes, double speedMph)
        : base(date, lengthInMinutes)
    {
        SpeedMph = speedMph;
    }

    public override double GetDistance()
    {
        return SpeedMph * (LengthInMinutes / 60);
    }

    public override double GetSpeed()
    {
        return SpeedMph;
    }

    public override double GetPace()
    {
        // Pace might not be meaningful for cycling, so we return minutes per mile inverse of speed
        return 60 / SpeedMph;
    }
}
