    
using System;
using System.Threading;

public abstract class Activity
{
    protected string Description { get; set; }
    protected int DurationInSeconds { get; set; }

    public Activity(string description)
    {
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {GetType().Name}: {Description}");
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        Finish();
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        DurationInSeconds = int.Parse(Console.ReadLine());
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    protected abstract void PerformActivity();

    protected virtual void Finish()
    {
        Console.WriteLine($"You have done a good job in {GetType().Name}. Duration: {DurationInSeconds} seconds");
        Thread.Sleep(2000); // Pause for 2 seconds
    }
}
