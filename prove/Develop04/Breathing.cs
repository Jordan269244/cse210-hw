using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

      protected override void PerformActivity()
    {
        Console.WriteLine("Starting breathing activity...");
        DateTime startTime = DateTime.Now;
        int count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < DurationInSeconds)
        {
            count++;
            Console.SetCursorPosition(0, Console.CursorTop); // Move cursor to the beginning of the line
            Console.Write(count % 4 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(2000); // Pause for 2 seconds
        }
    }
}


