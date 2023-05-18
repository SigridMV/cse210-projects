using System;
using System.Collections.Generic;

public class Simple:Goals
{
      

      public Simple(string name, string type, int point,bool isChecked):base(name,type,point)
      {
        this.IsChecked = isChecked;

      }
      
      public override void Display(int i)
      {
        if (IsChecked)
        {
            
            Console.WriteLine($"{i} [X] {Name} ({Type}) ");
           
   
        }    
        
        
        else
        {
            
            Console.WriteLine($"{i} [ ] {Name} ({Type}) ");
            
        }
      }

      public override string SaveFormat()
   {
      return $"simpleGoals:{Name},{Type},{Point},{IsChecked}";
   }
}