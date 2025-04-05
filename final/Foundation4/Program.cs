using System;

class Program
{
    static void Main(string[] args)
    {

        var activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0),  // 30 min, 3 miles
            new CyclingActivity(new DateTime(2022, 11, 3), 45, 12.0),  // 45 min, 12 mph
            new SwimmingActivity(new DateTime(2022, 11, 3), 40, 40)    // 40 min, 40 laps
        };


        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
