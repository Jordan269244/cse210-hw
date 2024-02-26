using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number?");
        //int magic = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magic)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        
            if (guess > magic)
            {
                Console.Write($"{guess} is too high, try a lower number");
            }
            else if (guess < magic)
            {
                Console.Write($"{guess} is too low, try a higher number.");
            }
            else
            {
                Console.Write($"YES! {magic} is the magic number!");
            }
        }

    }
}