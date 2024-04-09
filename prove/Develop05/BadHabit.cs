public class BadHabitGoal : Goal
{
    private string Type = "Bad Habit:";
    private bool Status;

    public BadHabitGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        Status = false;
    }

    public BadHabitGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        Status = status;
    }

    public Boolean Finished()
    {
        return Status;
    }

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return ($"{Type}; {GetName()}; {GetDescription()}; {GetPoints()}; {Status}");
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"You lost {GetPoints()} points!");
    }
}
