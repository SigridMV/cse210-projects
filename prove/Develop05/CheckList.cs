
public class Checklist : Goals

{

    private int _goalCount;
    private int _currentGoalCount;
    private int _bonus;


    public int GoalCount
    {
        get { return _goalCount; }
        set { _goalCount = value; }
    }

    public int CurrentGoalCount
    {
        get { return _currentGoalCount; }
        set { _currentGoalCount = value; }
    }

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
    }


    public Checklist(string name, string type, int point, int currentGoalCount, int goalCount, int bonus) : base(name, type, point)
    {
        _goalCount = goalCount;
        _bonus = bonus;
        _currentGoalCount = currentGoalCount;


    }

    public override void Display(int i)

    {
        if (IsChecked)
        {
            Console.Write($"{i} [X] {Name} ({Type}) ");
            Console.Write($" --Current completed:{_currentGoalCount}/{_goalCount}");
            Console.WriteLine($" You now have {Point} points.");
        }


        else
        {
            Console.Write($"{i} [ ] {Name} ({Type})");
            Console.Write($" --Current completed:{_currentGoalCount}/{_goalCount}");
            Console.WriteLine();
        }

    }

    public override string SaveFormat()
    {
        return $"Checklist:{Name},{Type},{Point},{_currentGoalCount},{_goalCount},{_bonus}";
    }

    public override int CompletedGoals()
    {
        if (IsChecked == false)
        {
            _currentGoalCount += 1;
            if (_currentGoalCount == _goalCount)
            {
                IsChecked = true;
                Console.WriteLine("Congratulations!");
                return Point + _bonus;

            }
            else
            {
                return Point;
            }
        }
        else
        {
            return 0;
        }
    }
}