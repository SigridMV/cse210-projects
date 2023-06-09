using System;
using System.IO;
public class ListingActivity : Activity
{
    // List of prompts to ask the user to list items related to.
    protected List<string> _prompts = new List<string>
    {
     " --- Who are people that you appreciate? ---",
     " --- What are personal strengths of yours?. ---",
     " --- Who are people that you have helped this week? ---",
     " --- When have you felt the Holy Ghost this month? ---" ,
     " --- Who are some of your personal heroes? ---"
    };
    // Counter for how many items the user lists.
    protected int _numAnswers = 0;

    public ListingActivity(string activity, string description) : base(activity, description)
    {

    }
    // Method to prompt the user with a random prompt from the list of prompts.
    public string GetPrompt()
    {
        Random promptIndex = new Random();
        int index = promptIndex.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"{prompt}");
        return prompt;
    }

    // Method to run the ListingActivity, prompting the user to list items and counting how many they list.
    public void ListingComplete()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt");
        GetPrompt();
        Console.WriteLine();
        Console.Write("\nEnter a filename to save your responses:");
        string fileName = Console.ReadLine() + ".txt";
        Console.Write("\nYou may begin in: ");
        PausingShowingCountdownTime(5);
        Console.WriteLine();

        while (DateTime.Now < _endTime)
        {
            string textToWrite = $"Responses to prompt\n";
            for (int i = 1; DateTime.Now < _endTime; i++)
            {
                Console.Write($"Response #{i}: ");
                string response = Console.ReadLine();
                textToWrite += $"{i}. {response}\n";
                _numAnswers++;
            }

            File.WriteAllText(fileName, textToWrite);
        }

        Console.WriteLine($"You list {_numAnswers} items.");
        LastMessage();
        Console.WriteLine();

    }
}