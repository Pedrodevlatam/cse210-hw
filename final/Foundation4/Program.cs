using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activities of each type
        activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new CyclingActivity(new DateTime(2022, 11, 4), 45, 25));
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 5), 60, 30));

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
