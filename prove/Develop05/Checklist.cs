using System;
public class ChecklistGoal : Goal
{
    public override void SetGoalDetails()
    {
        Console.Write("Enter checklist goal name: ");
        Name = Console.ReadLine();
        Console.Write("Enter description: ");
        Description = Console.ReadLine();
        Console.Write("Enter points: ");
        Points = int.Parse(Console.ReadLine());
       
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Checklist goal event recorded for {Name}. Points earned: {Points}");
    }

    public override string Serialize()
    {
        return $"Checklist;{Name};{Description};{Points}";
    }

    public override void Deserialize(string[] data)
    {
        Name = data[1];
        Description = data[2];
        Points = int.Parse(data[3]);
    }

    public override string ToString()
    {
        return $"{Name} ({Description}) - {Points} points";
    }
}