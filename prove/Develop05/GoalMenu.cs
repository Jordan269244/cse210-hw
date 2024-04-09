using System;

public class GoalMenu
{
    private string Menu = $@"
Goal Menu
===========================================
Types of Goals:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
4. Bad Habit Goal
5. Back to Main Menu
===========================================
Choose a goal type:  ";

    public string Input;
    private int choice = 0;

    public int GetGoalChoice()
    {
        Console.Write(Menu);

        Input = Console.ReadLine();
        choice = 0;
        
        try
        {
            choice = int.Parse(Input);
        }
        catch (FormatException)
        {
            choice = 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:  {ex.Message}");
        }
        return choice;
    }
}