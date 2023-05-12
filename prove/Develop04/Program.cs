using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the different activity classes
        BreathingActivity Breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity Reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        ListingActivity List = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        // Initialize userChoice to 0, so that the loop will run at least once
        int userChoice = 0;

        // Loop until the user enters 4 to quit
        while (userChoice != 4)
        {
            // Display the menu options
            Console.WriteLine("Menu Options:" +
            "\n1. Start breathing activity" +
            "\n2. Start reflecting activity" +
            "\n3. Start listing activity" +
            "\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            // Read the user's choice from the console
            userChoice = int.Parse(Console.ReadLine());

            // Use a switch statement to execute the appropriate activity
            switch (userChoice)
            {
                case 1:
                    Breathing.InicialMessage();
                    Breathing.DoBreathingExercise();
                    Breathing.LastMessage();
                break;
                case 2:
                    Reflect.InicialMessage();
                    Reflect.ReflectionComplete();
                    break;
                case 3:
                    List.InicialMessage();
                    List.ListingComplete();
                break;
                case 4:
                    Console.WriteLine("Goodbye");
                break;
                default:
                    Console.Write("Please enter a valid choice:\n");
                break;
            }
        }
    }
}