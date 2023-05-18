using System;
using System.Collections.Generic;

public class Simple:Goals
{
      

      public Simple(string name, string type, int point,bool isChecked):base(name,type,point)
      {
        this.isChecked = isChecked;

      }
      
      public override void Display(int i)
      {
        if (isChecked)
        {
            
            Console.WriteLine($"{i} [X] {_name} ({_type}) ");
            Console.WriteLine();
            Console.WriteLine($"You have {_point} points");
   
        }    
        
        
        else
        {
            
            Console.WriteLine($"{i} [ ] {_name} ({_type}) ");
            
        }
      }

      public override string Saveformat()
   {
      return $"simpleGoals:{_name},{_type},{_point},{isChecked}";
   }
}