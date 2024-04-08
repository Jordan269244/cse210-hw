using System;
using System.Reflection.Metadata.Ecma335;

public class Receipt
{
    public static void GenerateReceipt(string movieTitle, string movieRating, DateTime showtime, int totalCost)
    {
        Console.WriteLine("Receipt:");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Movie Title: {movieTitle}");
        Console.WriteLine($"Movie Rating: {movieRating}");
        Console.WriteLine($"Showtime: {showtime.ToString("hh:mm tt")}");
        Console.WriteLine("");
        Console.WriteLine($"Total: ${totalCost}");
        Console.WriteLine("------------------------------");
    }
    
}