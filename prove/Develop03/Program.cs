using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //A List for memorizing different scriptures 
        List <Reference> references = new List<Reference>
        {
            new Reference("Proverbs", "3", "5", "6","Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            new Reference("1 Nephi", "3", "7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Reference("Moroni", "10", "5", "And by the power of the Holy Ghost ye may know the truth of all things."),
            new Reference("DyC", "14", "7", "And, if you keep my commandments and endure to the end you shall have eternal life, which gift is the greatest of all the gifts of God.")
        };

        // Choose scriptures at random to present to the user
        Random random = new Random();
        int randomIndex = random.Next(references.Count);
        Reference randomReference = references[randomIndex];
        string randomText = randomReference.GetReference();

        // sometimes we memorize scripture but forget where it is so I will include the book, 
        //chapter and verses in the memory game.
        Scripture scripture = new Scripture(randomReference, randomText);

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

        // I add final comments of encouragement
        Console.WriteLine("Well done, you have memorized this scripture!");
        Console.WriteLine("Try again, memorize another one.");
        Console.WriteLine("You can do it!");
    }
}