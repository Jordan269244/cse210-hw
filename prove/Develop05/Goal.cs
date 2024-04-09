public abstract class Goal
{
    private string Type;
    private string Name;
    private string Description;
    private int Points;

    public Goal(string type, string name, string description, int points)
    {
        Type = type;
        Name = name;
        Description = description;
        Points = points;
    }

    public string GetType()
    {
        return Type;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetDescription()
    {
        return Description;
    }

    public int GetPoints()
    {
        return Points;
    }

    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}