using System;
public abstract class Goal
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }

    public abstract void SetGoalDetails();
    public abstract void RecordEvent();
    public abstract string Serialize();
    public abstract void Deserialize(string[] data);
}