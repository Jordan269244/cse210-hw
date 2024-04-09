using System;
using System.IO;

public class GoalManager
{
    private List<Goal> Goals = new List<Goal>();
    private int TotalPoints;

    public GoalManager()
    {
        TotalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return TotalPoints;
    }

    public void AddPoints(int points)
    {
        TotalPoints += points;
    }

    public void AddBonus(int bonus)
    {
        TotalPoints += bonus;
    }

    public void SetTotalPoints(int totalPoints)
    {
        TotalPoints = totalPoints;
    }

    public List<Goal> GetGoalsList()
    {
        return Goals;
    }

    public void ListGoals()
    {
        if (Goals.Count > 0)
        {
            Console.WriteLine("\nYour Goals:");

            int index = 1;
         
            foreach (Goal goal in Goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou have no goals!");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you achieve?  ");
        int select = int.Parse(Console.ReadLine()) - 1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(Goals);

        Console.WriteLine($"\n*** You now have {GetTotalPoints()} points! ***\n");
    }

    public void SaveGoals()
    {
        Console.Write("\nName your goal file:  ");
        string input = Console.ReadLine();
        string fileName = input + ".txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            
            foreach (Goal goal in Goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nName your goal file:  ");
        string input = Console.ReadLine();
        string fileName = input + ".txt";

        if (File.Exists(fileName))
        {
            string[] readText = File.ReadAllLines(fileName);

            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            
            readText = readText.Skip(1).ToArray();
           
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                if (entries[0] == "Bad Habit:")
                {
                    BadHabitGoal bGoal = new BadHabitGoal(type, name, description, points, status);
                    AddGoal(bGoal);
                }
            }
        }
    }
}
