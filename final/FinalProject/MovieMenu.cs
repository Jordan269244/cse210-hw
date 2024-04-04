using System;

public class MovieMenu
{

    private string _menu = $@"
    
Movie Types
===============================================
1.Action Movies
2.Comedy Movies
3.Horror Movies
4.Back to Main Menu
===============================================
What type of movie would you like watch?   ";

    public string _movieInput;
    private int _movieChoice = 0;

    public int MovieChoice()
    {
        Console.Write(_menu);

        _movieInput = Console.ReadLine();
        _movieChoice = 0;

        try
        {
            _movieChoice = int.Parse(_movieInput);
        }
        catch (FormatException)
        {
            _movieChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error: {exception.Message}");
            
        }
        return _movieChoice;
    }
}