using System;
using System.Collections.Generic;

namespace FitnessTracker
{

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        List<Activity> activities = new List<Activity>();

        Running run = new Running("03 Nov 2026", 30, 4.8);
        StationaryBike bike = new StationaryBike("04 Nov 2026", 45, 20.0);
        Swimming swim = new Swimming("05 Nov 2026", 40, 20); 

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        Console.WriteLine("--- FITNESS CENTER ACTIVITY SUMMARY ---\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
}

