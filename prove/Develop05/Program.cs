using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        GoalManagement goals = new GoalManagement();

        Console.Clear();  
        Console.Write("Welcome to the Eternal Quest Program");

        Console.Write($"You currently have {goals.GetTotalPoints()} points!");
       
        MainMenu choice = new MainMenu();
     
        GoalMenu goalChoice = new GoalMenu();


        int action = 0;
        while (action != 6)
        
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                   
                     
                    int goalInput = 0;
                    while (goalInput != 5)
                    
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                Console.WriteLine("What is the name of your goal?");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                                // Eternal Goal
                                Console.WriteLine("What is the name of your goal?");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                // Checklist Goal
                                Console.WriteLine("What is the name of your goal?");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                            case 4:
                                // Bad Habit Goal
                                Console.WriteLine("What is the name of your goal?");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of this bad habit?");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points should be subtracted for doing this bad habit?");
                                points = int.Parse(Console.ReadLine());
                                BadHabitGoal bGoal = new BadHabitGoal("Bad Habit:", name, description, points);
                                goals.AddGoal(bGoal);
                                goalInput = 5;
                                break;
                            case 5:
                                // Exit
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // List Goals
                     
                    Console.Write($"You currently have {goals.GetTotalPoints()} points!");
                    goals.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                     
                    Console.Write($"You currently have {goals.GetTotalPoints()} points!");
                    goals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                     
                    Console.Write($"You currently have {goals.GetTotalPoints()} points!");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    // Quite
                    Console.WriteLine("Thank you for using the Eternal Quest Program!");
                    break;
                default:
                    Console.WriteLine($"Sorry the option you entered is not valid.");
                    break;
            }
        }
    }
}