using System;

public class GoalMenu
{
    // Attributes 
    private string Menu = $@"
Goal Menu Options
===========================================
The Types of Goals are:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
4. Bad Habit Goal
5. Back to Main Menu
===========================================
What type of goal would you like to create?  ";

    public string GoalInput;
    private int goalChoice = 0;

   
    public int GoalChoice()
    
    {

        Console.Write(Menu);

        GoalInput = Console.ReadLine();
        goalChoice = 0;
        
        try
        {
            goalChoice = int.Parse(GoalInput);
        }
        catch (FormatException)
        {
            goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return goalChoice;
    }



}