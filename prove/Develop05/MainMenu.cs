using System;

public class MainMenu
{
    
    private string Menu = $@"
==================================================
Please select one of the following options:
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Goal Event
6. Exit
==================================================
Select an option from the menu:  ";

    public string UserInput;
    private int userChoice = 0;

 
    public int UserChoice()
    
    {
        Console.Write(Menu);

        UserInput = Console.ReadLine();
        userChoice = 0;
      
        return userChoice;
    }



}