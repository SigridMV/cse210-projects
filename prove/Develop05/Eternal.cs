using System;
using System.Collections.Generic;

public class Eternal : Goals
{
    public Eternal(string name, string type, int point) : base(name, type, point)
    {

    }
    public override void Display(int i)
    {
        if (IsChecked)
        {
            Console.WriteLine($"{i} [X] {Name} ({Type})");
        }
        else
        {
            Console.WriteLine($"{i} [ ] {Name} ({Type})");
        }
    }

    public override int CompletedGoals()
    {
        if (!IsChecked)
        {
            IsChecked = true;
            return Point;
        }

        return 0;
    }

    public override string SaveFormat()
    {
        return $"EternalGoals:{Name},{Type},{Point},{IsChecked}";
    }
}


