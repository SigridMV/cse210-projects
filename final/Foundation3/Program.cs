using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("Street 23", "Houston", "USA");
        Lectures lectures = new Lectures("Lecture 1", "Lecture Description", new DateTime(2023, 6, 28), new TimeSpan(10, 30, 0), address1, "Mario Ortega", 200);

        Address address2 = new Address("Principal 123", "Salt Lake", "USA");
        Receptions receptions = new Receptions("Reception 1", "Reception Description", new DateTime(2023, 8, 20), new TimeSpan(18, 45, 0), address2, "contact@eventhorizon.com");

        Address address3 = new Address("New york 2456", "New York", "USA");
        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("Outdoor Gathering 1", "Outdoor Gathering Description", new DateTime(2023, 9, 1), new TimeSpan(9, 30, 0), address3, "Cold");

        
        Console.WriteLine("Lectures Marketing Event Horizon company:");
        Console.WriteLine();
        Console.WriteLine("Standard Details:\n" + lectures.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + lectures.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + lectures.GetShortDescription());

        Console.WriteLine("\n----------------------------------------\n");

        Console.WriteLine("Reception Marketing Event Horizon company:\n");
        Console.WriteLine("Standard Details:\n" + receptions.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + receptions.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + receptions.GetShortDescription());

        Console.WriteLine("\n----------------------------------------\n");

        Console.WriteLine("Outdoor Gatherings Marketing Event Horizon company:\n");
        Console.WriteLine("Standard Details:\n" + outdoorGatherings.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + outdoorGatherings.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + outdoorGatherings.GetShortDescription());

        Console.ReadLine();
    }

    //I got help from a web page, I include the link to that page in my comments.
    // https://www.w3schools.com/cs/index.php
}