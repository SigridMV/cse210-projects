using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        List list = new List();
        SaveLoad saveload = new SaveLoad();

        Reflecting reflecting = new Reflecting();

        while (userInput != "6")
        {
            Console.WriteLine();
            reflecting.DisplayRandomPrompt();
            Console.WriteLine();

            Console.WriteLine($"You have {list.TotalPoint} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                list.Menu();

            }
            else if (userInput == "2")
            {
                list.DisplayGoals();
            }
            else if (userInput == "3")
            {
                saveload.Save(list.MenuList);
            }
            else if (userInput == "4")
            {
                saveload.Load(list.MenuList);
            }
            else if (userInput == "5")
            {
                list.DisplayGoals();
                Console.Write("Which goal did you accomplish? ");
                string choice = Console.ReadLine();
                list.TotalPoint += list.MenuList[int.Parse(choice) - 1].CompletedGoals();
                Console.WriteLine($"Congratulations! You have {list.TotalPoint} points");


            }

            else
            {
                Console.WriteLine("Invalid goal selection. Try Again");
            }
        }
    }
}

// Showing Creativity and Exceeding Requirements
// I have incorporated the Reflecting class and using the DisplayRandomPrompt() method, 
// this can enhance my program by adding motivational and inspirational prompts related to goal setting and achievement. 
// The method ensures that messages are displayed randomly and without repetition until all available messages have been displayed.