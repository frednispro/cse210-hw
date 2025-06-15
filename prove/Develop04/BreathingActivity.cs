using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity helps you relax by breathing slowly. Focus on your breath.";
    }

    protected override void DoActivity()
    {
        int rounds = _duration / 6;
        for (int i = 0; i < rounds; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.Write("Breathe out... ");
            ShowCountdown(3);
            Console.WriteLine();
        }
    }
}
