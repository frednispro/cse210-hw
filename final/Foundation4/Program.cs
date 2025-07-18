using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(DateTime.Now, 30, 3.1));   // 3.1 miles in 30 mins
        activities.Add(new Cycling(DateTime.Now, 60, 15));    // 60 mins @ 15 mph
        activities.Add(new Swimming(DateTime.Now, 45, 30, 25)); // 30 laps in 25m pool, 45 mins

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
