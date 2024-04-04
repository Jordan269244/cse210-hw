using System;

public class MainMenu
{

    private string _menu = $@"
    
    Welcome! Please add any 
    tickets or snack before 
    getting your receipt.
    
    ===========================================
    Please select one of the following options:

    1. Movies
    2. Snacks
    3. View Receipt
    4. Exit

    ===========================================";

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