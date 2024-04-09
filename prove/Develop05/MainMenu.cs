using System;

public class MainMenu
{
    private string Menu = $@"
=====================================
Options:
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Goal Event
6. Exit
=====================================
Choose:  ";

    public string Input;
    private int choice = 0;

    public int GetUserChoice()
    {
        Console.Write(Menu);

        Input = Console.ReadLine();
        choice = 0;
      
        return choice;
    }
}