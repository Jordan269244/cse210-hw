using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished");

       
        List<int> numbers = new List<int>();


        int number = -1;

        while(number != 0)
        {   
            Console.Write("Enter a number:");
            string userInput = Console.ReadLine();
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
               numbers.Add(number); 
            }
        
        }

        int sum = 0;
        foreach (int amount in numbers)
        {
            sum += amount;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

           int max = numbers[0];

        foreach (int amount in numbers)
        {
            if (amount > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = amount;
            }
        }

        Console.WriteLine($"The max is: {max}");
    

    }
}