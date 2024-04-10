using System;
public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints;

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Bad Habit Goal");
        Console.Write("Choose: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid option.");
            return;
        }

        Goal goal;
        switch (choice)
        {
            case 1:
                goal = new SimpleGoal();
                break;
            case 2:
                goal = new EternalGoal();
                break;
            case 3:
                goal = new ChecklistGoal();
                break;
            case 4:
                goal = new BadHabitGoal();
                break;
            default:
                return;
        }

        goal.SetGoalDetails();
        goals.Add(goal);
    }

    public void ListGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet!");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string fileName = Console.ReadLine() + ".txt";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(totalPoints);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string fileName = Console.ReadLine() + ".txt";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            totalPoints = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine().Split(';');
                Goal goal;
                switch (data[0])
                {
                    case "Simple":
                        goal = new SimpleGoal();
                        break;
                    case "Eternal":
                        goal = new EternalGoal();
                        break;
                    case "Checklist":
                        goal = new ChecklistGoal();
                        break;
                    case "BadHabit":
                        goal = new BadHabitGoal();
                        break;
                    default:
                        continue;
                }
                goal.Deserialize(data);
                goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordGoalEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet!");
            return;
        }

        ListGoals();
        Console.Write("Select goal to record event: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goal goal = goals[index - 1];
        goal.RecordEvent();
        totalPoints += goal.Points;
        Console.WriteLine($"Event recorded. Total points: {totalPoints}");
    }
}