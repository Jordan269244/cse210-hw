public class SimpleGoal : Goal
{
    private string Type = "Simple Goal:";
    private bool Status;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        Status = false;
    }

    public SimpleGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        Status = status;
    }

    public Boolean Finished()
    {
        return Status;
    }

    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }

    public override string SaveGoal()
    {
        return ($"{Type}; {GetName()}; {GetDescription()}; {GetPoints()}; {Status}");
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
       Status = true;
       Console.WriteLine($"Congratulations! You earned {GetPoints()} points!");
    }
}