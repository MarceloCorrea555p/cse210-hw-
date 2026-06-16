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

        Running run = new Running("15 Nov 2026", 30, 6.0);
        StationaryBike bike = new StationaryBike("16 Nov 2026", 33, 35.0);
        Swimming swim = new Swimming("18 Nov 2026", 25, 15); 

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

