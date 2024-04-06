using System;

public class ChecklistGoal : Goal
{

    private string Type = "Check List Goal:";
    private int NumberTimes;
    private int BonusPoints;
    private bool Status;
    private int Count;


    
    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
    {
        Status = false;
        NumberTimes = numberTimes;
        BonusPoints = bonusPoints;
        Count = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(type, name, description, points)
    {
        Status = status;
        NumberTimes = numberTimes;
        BonusPoints = bonusPoints;
        Count = count;
    }

    public int GetTimes()
    {
        return NumberTimes;
    }
    public void SetTimes()
    {
        Count = Count + 1;
    }
     public int GetCount()
    {
        return Count;
    }
    public void SetCount()
    {

    }
     public int GetBonusPoints()
    {
        return BonusPoints;
    }
    public Boolean Finished()
    {
        return Status;
    }

    
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }

    }
    public override string SaveGoal()
    {
        return ($"{Type}; {GetName()}; {GetDescription()}; {GetPoints()}; {Status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {Status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (Count == NumberTimes)
        {
            Status = true;
            points = points + BonusPoints;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

}