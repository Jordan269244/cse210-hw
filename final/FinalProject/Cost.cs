using System;

public class Cost
{
    public int TotalCost()
    {
        Console.WriteLine("How many tickets would you like for this movie?");
        int people = int.Parse(Console.ReadLine());
        int cost = people * 15;
        Console.WriteLine($"You have bought {people} tickets for {cost} dollars.");
        return cost;

    }

}