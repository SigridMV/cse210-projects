using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        string text = "'Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.'";
        Scripture scripture = new Scripture(reference, text);

        scripture.Display();

        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string userInput = Console.ReadLine();

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            scripture.RemoveWords();
            scripture.Display();
            userInput = Console.ReadLine();
        }

        Console.WriteLine("Well done, you memorized the scripture!");
    }
}