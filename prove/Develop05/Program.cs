using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo ti = new CultureInfo("en-US", false).TextInfo;
        GoalManager gm = new GoalManager();

        Console.Clear();  
        Console.WriteLine("Welcome to the Quest Program");

        Console.WriteLine($"You currently have {gm.GetTotalPoints()} points!");
       
        MainMenu menu = new MainMenu();
     
        GoalMenu gmenu = new GoalMenu();

        int choice = 0;
        while (choice != 6)
        {
            choice = menu.GetUserChoice();
            switch (choice)
            {
                case 1:
                    int gInput = 0;
                    while (gInput != 5)
                    {
                        gInput = gmenu.GetGoalChoice();
                        switch (gInput)
                        {
                            case 1:
                                Console.WriteLine("What is your goal?");
                                string name = Console.ReadLine();
                                name = ti.ToTitleCase(name);
                                Console.WriteLine("Give a brief description of your goal:");
                                string desc = Console.ReadLine();
                                desc = ti.ToTitleCase(desc);
                                Console.Write("How many points for this goal?");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, desc, points);
                                gm.AddGoal(sGoal);
                                gInput = 5;
                                break;
                            case 2:
                                Console.WriteLine("Name your goal:");
                                name = Console.ReadLine();
                                name = ti.ToTitleCase(name);
                                Console.WriteLine("Describe your goal:");
                                desc = Console.ReadLine();
                                desc = ti.ToTitleCase(desc);
                                Console.Write("Points for this goal?");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, desc, points);
                                gm.AddGoal(eGoal);
                                gInput = 5;
                                break;
                            case 3:
                                Console.WriteLine("Name your goal:");
                                name = Console.ReadLine();
                                name = ti.ToTitleCase(name);
                                Console.WriteLine("Describe your goal:");
                                desc = Console.ReadLine();
                                desc = ti.ToTitleCase(desc);
                                Console.Write("Points for this goal?");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times for bonus?");
                                int number = int.Parse(Console.ReadLine());
                                Console.Write("Bonus points?");
                                int bonus = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, desc, points, number, bonus);
                                gm.AddGoal(clGoal);
                                gInput = 5;
                                break;
                            case 4:
                                Console.WriteLine("Name your goal:");
                                name = Console.ReadLine();
                                name = ti.ToTitleCase(name);
                                Console.WriteLine("Describe this bad habit:");
                                desc = Console.ReadLine();
                                desc = ti.ToTitleCase(desc);
                                Console.Write("Points to subtract?");
                                points = int.Parse(Console.ReadLine());
                                BadHabitGoal bGoal = new BadHabitGoal("Bad Habit:", name, desc, points);
                                gm.AddGoal(bGoal);
                                gInput = 5;
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine($"\nInvalid option.");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine($"You have {gm.GetTotalPoints()} points!");
                    gm.ListGoals();
                    break;
                case 3:
                    gm.SaveGoals();
                    break;
                case 4:
                    Console.WriteLine($"You have {gm.GetTotalPoints()} points!");
                    gm.LoadGoals();
                    break;
                case 5:
                    Console.WriteLine($"You have {gm.GetTotalPoints()} points!");
                    gm.RecordGoalEvent();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using the Quest Program!");
                    break;
                default:
                    Console.WriteLine($"Invalid option.");
                    break;
            }
        }
    }
}
