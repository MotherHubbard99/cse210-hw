using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            //create activities without user input
            new Running(4.5, 28, new DateTime(2024, 10, 31)),
            
            new Cycling(17, 56, new DateTime(2024, 09, 12)),
            new Swimming(20, 8, new DateTime(2024, 04, 12)),
        };
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}