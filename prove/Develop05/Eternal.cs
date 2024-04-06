using System;

public class EternalGoal : Goal
{
   
    private string Type = "Eternal Goal:";
    private bool Status;


   
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        Status = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        Status = status;
    }



    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{Type}; {GetName()}; {GetDescription()}; {GetPoints()}; {Status}");
    }
    public override string LoadGoal()
    {
        return ($"{Type}; {GetName()}; {GetDescription()}; {GetPoints()}; {Status}");
    }
      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }


}