using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        int menuUserInput = 0;


        List<string> menu = new List<string>
        {
            "Please select one of the following choices",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do? "
        };

        while (menuUserInput != 5)
        {
            
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuUserInput = int.Parse(Console.ReadLine());
            string numeroString = Convert.ToString(menuUserInput);
            
            switch (numeroString)
            {
                case "1":
                    journal.CreateJournalEntry();
                    break;
                case "2":
                    journal.DisplayJournalEntries();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromCSV(loadFilename);
                    break;
                case "4":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToCSV(saveFilename);
                    break;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine();
    }
}
