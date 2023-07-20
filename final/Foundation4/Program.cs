using System;
using System.Collections.Generic;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2023, 06, 29), 30, 3.0));
            activities.Add(new Running(new DateTime(2023, 06, 30), 30, 4.8));
            activities.Add(new StationaryBicycle(new DateTime(2023, 07, 1), 45, 25.0));
            activities.Add(new Swimming(new DateTime(2023, 07, 2), 40, 30));

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
