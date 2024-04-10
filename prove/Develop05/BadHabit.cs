public class BadHabitGoal : Goal
{
    public override void SetGoalDetails()
    {
        Console.Write("Enter bad habit name: ");
        Name = Console.ReadLine();
        Console.Write("Enter description: ");
        Description = Console.ReadLine();
        Console.Write("Enter points: ");
        Points = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Bad habit event recorded for {Name}. Points deducted: {Points}");
    }

    public override string Serialize()
    {
        return $"BadHabit;{Name};{Description};{Points}";
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