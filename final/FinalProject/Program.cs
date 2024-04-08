using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();


        MainMenu choice = new MainMenu();
        string movieTitle = "";
        string movieRating = "";
        int selectedShowtimeIndex = -1;
        int totalCost = 0;
        DateTime showtime = DateTime.MinValue;
        Cost costCalculator = new Cost();
        MovieMenu movieChoice = new MovieMenu();

        int action = 0;
        while (action != 3)

        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    Console.Clear();
                    MovieMenu _movieMenu = new MovieMenu();
                    int movieGenreChoice = _movieMenu.MovieChoice();

                    switch (movieGenreChoice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Action Movies:");
                            for (int i = 0; i < Action.actionMovies.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {Action.actionMovies[i].GetTitle()}:{Action.actionMovies[i].GetSummary()}");
                                Console.WriteLine($"   Age Rating: {Action.actionMovies[i].GetRating()}      Movie Length: {Action.actionMovies[i].GetLength()}");
                            }
                            int actionMovieChoice = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                                                                                       // Retrieve the showtimes for the selected action movie
                            if (actionMovieChoice >= 0 && actionMovieChoice < Action.actionMovies.Count)
                            {   
                                movieTitle = Action.actionMovies[actionMovieChoice].GetTitle();
                                movieRating = Action.actionMovies[actionMovieChoice].GetRating();
                                totalCost = costCalculator.TotalCost();
                                List<DateTime> showtimes = ShowTime.GetMovieShowtimes(Action.actionMovies[actionMovieChoice]);
                                Console.WriteLine("Choose a showtime:");
                                for (int i = 0; i < showtimes.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {showtimes[i].ToString("hh:mm tt")}");
                                }
                                selectedShowtimeIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                                                                                           
                                if (selectedShowtimeIndex >= 0 && selectedShowtimeIndex < showtimes.Count)
                                { 
                                    showtime = showtimes[selectedShowtimeIndex]; // Assign the selected showtime to the 'showtime' variable
                                    Console.WriteLine($"You have selected {showtime.ToString("hh:mm tt")} as the showtime.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid showtime selection.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid action movie selection.");
                            }
                            break;


                        case 2:
                            Console.Clear();
                            Console.WriteLine("Comedy Movies:");
                            for (int i = 0; i < Comedy.comedyMovies.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {Comedy.comedyMovies[i].GetTitle()}:{Comedy.comedyMovies[i].GetSummary()}");
                                Console.WriteLine($"  Age Rating: {Comedy.comedyMovies[i].GetRating()}      Movie Length: {Comedy.comedyMovies[i].GetLength()}");
                            }
                            int comedyMovieChoice = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                                                                                       // Retrieve the showtimes for the selected comedy movie
                            if (comedyMovieChoice >= 0 && comedyMovieChoice < Comedy.comedyMovies.Count)
                            {
                                
                                movieTitle = Comedy.comedyMovies[comedyMovieChoice].GetTitle();
                                movieRating = Comedy.comedyMovies[comedyMovieChoice].GetRating();
                                totalCost = costCalculator.TotalCost();
                                List<DateTime> showtimes = ShowTime.GetMovieShowtimes(Comedy.comedyMovies[comedyMovieChoice]);
                                Console.WriteLine("Choose a showtime:");
                                for (int i = 0; i < showtimes.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {showtimes[i].ToString("hh:mm tt")}");
                                }
                                selectedShowtimeIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                                                             // Validate the selected showtime index
                                if (selectedShowtimeIndex >= 0 && selectedShowtimeIndex < showtimes.Count)
                                {
                                    showtime = showtimes[selectedShowtimeIndex]; // Assign the selected showtime to the 'showtime' variable
                                    Console.WriteLine($"You have selected {showtime.ToString("hh:mm tt")} as the showtime.");
                                    
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Invalid showtime selection.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid comedy movie selection.");
                            }
                            
                            break;


                        case 3:
                            Console.Clear();
                            Console.WriteLine("Horror Movies:");
                            for (int i = 0; i < Horror.horrorMovies.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {Horror.horrorMovies[i].GetTitle()}:{Horror.horrorMovies[i].GetSummary()}");
                                Console.WriteLine($"   Age Rating: {Horror.horrorMovies[i].GetRating()}      Movie Length: {Horror.horrorMovies[i].GetLength()}");
                            }
                            int horrorMovieChoice = int.Parse(Console.ReadLine()) - 1;
                            if (horrorMovieChoice >= 0 && horrorMovieChoice < Horror.horrorMovies.Count)
                            {
                                movieTitle = Horror.horrorMovies[horrorMovieChoice].GetTitle();
                                movieRating = Horror.horrorMovies[horrorMovieChoice].GetRating();
                                totalCost = costCalculator.TotalCost();
                                List<DateTime> showtimes = ShowTime.GetMovieShowtimes(Horror.horrorMovies[horrorMovieChoice]);
                                // Display and select showtime logic
                                Console.WriteLine("Choose a showtime:");
                                for (int i = 0; i < showtimes.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {showtimes[i].ToString("hh:mm tt")}");
                                }
                                selectedShowtimeIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                                
                                if (selectedShowtimeIndex >= 0 && selectedShowtimeIndex < showtimes.Count)
                                {
                                    showtime = showtimes[selectedShowtimeIndex]; // Capture the selected showtime
                                    Console.WriteLine($"You have selected {showtime.ToString("hh:mm tt")} as the showtime.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid showtime selection.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid horror movie selection.");
                            }
                            break;

                        case 4:
                            //exit
                            break;

                        default:
                            Console.WriteLine($"Sorry, that is an invalid option");
                            break;
                    }
                    break;

                case 2:

                    Console.Clear();
                    if (!string.IsNullOrEmpty(movieTitle) && !string.IsNullOrEmpty(movieRating) && showtime != DateTime.MinValue)
                    {
                        Receipt.GenerateReceipt(movieTitle, movieRating, showtime, totalCost);
                        Console.WriteLine("Press Enter to return to the main menu...");
                        Console.ReadLine(); // Wait for user to press Enter
                    }
                    else
                    {
                        Console.WriteLine("Invalid receipt generation: Missing movie information or showtime.");
                    }
                    break;
        

                case 3:
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