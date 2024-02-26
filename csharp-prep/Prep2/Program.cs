using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90 )
        {
            letter = "A";  
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F"; 
        }

        string symbol = "";

        if ((percent % 10) >= 7)
        {
            symbol  = "+";
        }
        else if ((percent % 10) <=3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }


        Console.WriteLine($"You have a {letter}{symbol} in the class");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.Write("Congrats on passing the class!");
        }
        else
        {
            Console.Write("You aren't doing so hot, keep working at it!");
        }
    }
}