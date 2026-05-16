using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
    

        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        int sum = 0;
        
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);

            }

        } while (userNumber != 0);


        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The average is: {average}");
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                
                maximum = number;
            }
        }

        Console.WriteLine($"The maximum is: {maximum}");

    }
}        
