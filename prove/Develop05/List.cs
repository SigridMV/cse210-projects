using System;
using System.Collections.Generic;

public class List
{
    private List<Goals> _menuList = new List<Goals>();
    private string _menuInput;

    private int _totalPoint = 0;

    public List<Goals> MenuList
    {
        get { return _menuList; }
        set { _menuList = value; }
    }

    public string MenuInput
    {
        get { return _menuInput; }
        set { _menuInput = value; }
    }

    public int TotalPoint
    {
        get { return _totalPoint; }
        set { _totalPoint = value; }
    }


    public void Menu()
    {
        while (_menuInput != "4")
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. CheckList Goal");
            Console.WriteLine("------------------------");

            Console.Write("Which type of goal would you like to create? ");

            _menuInput = Console.ReadLine();

            string goalName;
            string goalType;
            int goalPoint;
            int goalTimes = 0;
            int bonus;

            switch (_menuInput)
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

                    _menuList.Add(simple);


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

                    _menuList.Add(eternal);

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
                    _menuList.Add(checklist);

                    return;
            }
        }
    }


    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goals l in _menuList)
        {
            l.Display(i);
            i += 1;
        }
    }
}