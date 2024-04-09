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

    public int GetCount()
    {
        return Count;
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
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
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

    public override void RecordGoalEvent(List<Goal> goals)
    {
        Count++;
        if (Count == NumberTimes)
        {
            Status = true;
            AddPoints(GetBonusPoints());
            Console.WriteLine($"Congratulations! You earned {GetBonusPoints()} bonus points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {GetPoints()} points!");
        }
    }
}
