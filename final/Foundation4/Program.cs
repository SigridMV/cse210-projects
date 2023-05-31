using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = new DateTime(2023, 05, 26);

        activities.Add(new Running(date, 40, 4.0));
        activities.Add(new Cycling(date, 50, 2.0));
        activities.Add(new Swimming(date, 80, 15));

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            
        }
        Console.WriteLine();
    }

    //I got help from a web page, I include the link to that page in my comments.
    // https://www.w3schools.com/cs/index.php
}