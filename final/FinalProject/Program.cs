using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();


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
                    MovieMenu movieMenu = new MovieMenu();
                    int movieGenreChoice = movieMenu.MovieChoice();
                    int selectedShowtimeIndex = -1;
                    switch (movieGenreChoice)
                    {   case 1:
                            Console.Clear();
                            Console.WriteLine("Action Movies:");
                            for (int i = 0; i < Action.actionMovies.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {Action.actionMovies[i].GetTitle()}:{Action.actionMovies[i].GetSummary()}");
                                Console.WriteLine($"   Age Rating: {Action.actionMovies[i].GetRating()}      Movie Length: {Action.actionMovies[i].GetLength()}");
                            }
                            int actionMovieChoice = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                            // Retrieve the showtimes for the selected action movie
                            List<DateTime> actionShowtimes = ShowTime.GetMovieShowtimes(Action.actionMovies[actionMovieChoice]);
                            Console.WriteLine("Choose a showtime:");
                            for (int i = 0; i < actionShowtimes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {actionShowtimes[i].ToString("hh:mm tt")}");
                            }
                            selectedShowtimeIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                            // Validate the selected showtime index
                            if (selectedShowtimeIndex >= 0 && selectedShowtimeIndex < actionShowtimes.Count)
                            {
                                DateTime selectedShowtime = actionShowtimes[selectedShowtimeIndex];
                                Console.WriteLine($"You have selected {selectedShowtime.ToString("hh:mm tt")} as the showtime.");
                                // Proceed with further actions (e.g., purchasing tickets or snacks)
                            }
                            else
                            {
                                Console.WriteLine("Invalid showtime selection.");
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
                            List<DateTime> comedyShowtimes = ShowTime.GetMovieShowtimes(Comedy.comedyMovies[comedyMovieChoice]);
                            Console.WriteLine("Choose a showtime:");
                            for (int i = 0; i < comedyShowtimes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {comedyShowtimes[i].ToString("hh:mm tt")}");
                            }
                            selectedShowtimeIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                            // Validate the selected showtime index
                            if (selectedShowtimeIndex >= 0 && selectedShowtimeIndex < comedyShowtimes.Count)
                            {
                                DateTime selectedShowtime = comedyShowtimes[selectedShowtimeIndex];
                                Console.WriteLine($"You have selected {selectedShowtime.ToString("hh:mm tt")} as the showtime.");
                                // Proceed with further actions (e.g., purchasing tickets or snacks)
                            }
                            else
                            {
                                Console.WriteLine("Invalid showtime selection.");
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
                            int horrorMovieChoice = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                            // Validate the horror movie choice index
                            if (horrorMovieChoice >= 0 && horrorMovieChoice < Horror.horrorMovies.Count)
                            {
                                List<DateTime> horrorShowtimes = ShowTime.GetMovieShowtimes(Horror.horrorMovies[horrorMovieChoice]);
                                Console.WriteLine("Choose a showtime:");
                                for (int i = 0; i < horrorShowtimes.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {horrorShowtimes[i].ToString("hh:mm tt")}");
                                }
                                selectedShowtimeIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match the index
                                // Validate the selected showtime index
                                if (selectedShowtimeIndex >= 0 && selectedShowtimeIndex < horrorShowtimes.Count)
                                {
                                    DateTime selectedShowtime = horrorShowtimes[selectedShowtimeIndex];
                                    Console.WriteLine($"You have selected {selectedShowtime.ToString("hh:mm tt")} as the showtime.");
                                    // Proceed with further actions (e.g., purchasing tickets or snacks)
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
                        default: Console.WriteLine($"Sorry, that is an invalid option");
                            break;         
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