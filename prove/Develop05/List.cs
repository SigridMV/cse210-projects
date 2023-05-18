using System;
using System.Collections.Generic;

public class List
{
    public List<Goals> menuList = new List<Goals>();
    public string menuInput;

    public int totalPoint = 0;


    public void Menu()
    {
        while (menuInput != "4")
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. CheckList Goal");
            Console.WriteLine("------------------------");

            Console.Write("Which type of goal would you like to create? ");

            menuInput = Console.ReadLine();

            string goalName;
            string goalType;
            int goalPoint;
            int goalTimes = 0;
            int bonus;

            switch (menuInput)
            {
                case "1":
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    goalType = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    goalPoint = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    // goalnumber +=1;
                    Simple simple = new Simple(goalName, goalType, goalPoint, false);

                    menuList.Add(simple);


                    return;



                case "2":
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    goalType = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal ?  ");
                    goalPoint = int.Parse(Console.ReadLine());
                    // goalnumber +=1;
                    Console.WriteLine();
                    Eternal eternal = new Eternal(goalName, goalType, goalPoint);

                    menuList.Add(eternal);

                    return;

                case "3":
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    goalType = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    goalPoint = int.Parse(Console.ReadLine());
                    // goalnumber +=1;

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    goalTimes = int.Parse(Console.ReadLine());


                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonus = int.Parse(Console.ReadLine());
                    Checklist checklist = new Checklist(goalName, goalType, goalPoint, 0, goalTimes, bonus);
                    menuList.Add(checklist);

                    return;
            }
        }
    }


    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goals l in menuList)
        {
            l.Display(i);
            i += 1;
        }
    }
}