using System;

public class MainMenu
{
    
    private string _menu = $@"

Please select one of the following options:
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Goal Event
6. Quit
Select an option from the menu:  ";

    public string _userInput;
    private int _userChoice = 0;

 
    public int UserChoice()
    
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;
      
        return _userChoice;
    }



}