using System;
using System.Collections.Generic;

public class Checklist:Goals

{
      
      public int _goalCount;
      public int _currentGoalCount;
      public int _bonus;
      List<Goals> MenuList= new List<Goals>();
      public Checklist(string name, string type, int point,int currentGoalCount,int goalCount,int bonus):base(name,type,point)
      {
            _goalCount = goalCount;
            _bonus = bonus;
            _currentGoalCount = currentGoalCount;


      }

      public override void Display(int i)

      {
            if (isChecked)
        {
            Console.WriteLine($"{i} [x] {_name} ({_type}) ");
            Console.WriteLine($"Current completed:{_currentGoalCount}/{_goalCount}");
            Console.WriteLine($"You have  {_point} points Now");
        }    
        
        
        else
        {   
            Console.WriteLine($"{i} [ ] {_name} ({_type})");
            Console.WriteLine($"Current completed:{_currentGoalCount}/{_goalCount}");
        }
                        
      }

    public override string Saveformat()
   {
      return $"Checklist:{_name},{_type},{_point},{_currentGoalCount},{_goalCount},{_bonus}";
   }

    public override int CompletedGoals()
   {
        if (isChecked == false) {
            _currentGoalCount += 1;
            if ( _currentGoalCount == _goalCount)
            {
                isChecked = true;
                Console.WriteLine("!!!");
                return _point + _bonus;
                
            }
            else{
                return _point;
            }
        }
        else {
            return 0;
        }   
    }
}