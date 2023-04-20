using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int numGuesses = 0;


            do
            {

                Console.Write("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations!, you guessed it at {numGuesses}!");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

    }
}
