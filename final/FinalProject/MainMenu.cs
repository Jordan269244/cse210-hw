public class MainMenu
{
    private string _menu = $@"
    
    Welcome! Please add any 
    tickets or snack before 
    getting your receipt.
    
    ===========================================
    Please select one of the following options:
    1. Movies
    2. View Receipt
    3. Exit
    ===========================================";

    private int _userChoice;

    public int UserChoice()
    {
        Console.Clear();
        Console.WriteLine(_menu);

        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out _userChoice) && _userChoice >= 1 && _userChoice <= 3)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 3.");
            }
        }

        return _userChoice;
    }
}
