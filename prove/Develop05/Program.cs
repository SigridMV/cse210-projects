using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        List list = new List();
        SaveLoad saveload = new SaveLoad();

        while (userInput != "6")
        {
            Console.WriteLine($"You have {list.totalPoint} points.");
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
                saveload.Save(list.menuList);
            }
            else if (userInput == "4")
            {
                saveload.Load(list.menuList);
            }
            else if (userInput == "5")
            {
                list.DisplayGoals();
                Console.Write("Which goal did you accomplish? ");
                string choice = Console.ReadLine();
                list.totalPoint += list.menuList[int.Parse(choice) - 1].CompletedGoals();
                Console.WriteLine($"Congratulations! You have {list.totalPoint} points");


            }

            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }
    }
}