using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();
        int userNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do{
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber !=0 )
            {
                userNumbers.Add(userNumber);
            }

        }while(userNumber != 0);

        int sum = userNumbers.Sum();
        double average = (double)sum / userNumbers.Count;
        int max = userNumbers.Max();
        
        Console.WriteLine($"The sum is: {sum} ");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The largest number is: {max} ");
        // Console.WriteLine("The smallest positive number is: ");
        // Console.WriteLine("The sorted list is: ");

    }
}