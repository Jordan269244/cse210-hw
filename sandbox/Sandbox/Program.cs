using System;


class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.Write("Welcome to the Theater Program!");

        MainMenu choice = new MainMenu();

        MovieMenu movieChoice = new MovieMenu();

        int action = 0;
        while(action != 4)
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:

                    Console.Clear();
                    int movieInput = 0;
                    while (movieInput != 4)
                    {
                        movieInput = movieChoice.MovieChoice();
                        switch (movieInput)
                        {
                            case 1:
                            //Action Moibe
                                break;
                            case 2:
                            //Comedy Movie
                                break;
                            case 3:
                            //Horror Movie
                                break;
                            case 4:
                            //exit
                                break;
                            default: Console.WriteLine($"Sorry, that is an invalid option");
                                break;

                        }      
                    }
                    break;
                case 2:
                //Snacks
                    break;
                case 3:
                //Receipt
                    break;
                case 4:
                //Quit
                    Console.WriteLine(" Thank you for your business, come again!");
                    break;
                default: 
                    Console.WriteLine($"Sorry, that is an invalid option");
                    break;
            }
        }

    }
}