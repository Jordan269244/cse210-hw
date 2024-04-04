using System;
using System.Collections.Generic;

public class ShowTime
{
    // This method generates and returns random showtimes
    public static List<DateTime> GenerateShowtimes()
    {
        // Define your list of showtimes here
        List<DateTime> showtimes = new List<DateTime>
        {
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 15, 0), // 11:15 AM
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0),  // 12:00 PM
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 30, 0), // 3:30 PM
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0),  // 5:00 PM
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 45, 0) // 6:45 PM
            // Add more showtimes as needed
        };

        return showtimes;
    }

    // This method randomly selects and returns the specified number of showtimes from the provided list
    public static List<DateTime> SelectRandomShowtimes(List<DateTime> allShowtimes, int count)
    {
        Random rand = new Random();
        List<DateTime> randomShowtimes = new List<DateTime>();

        // Ensure that the count is not greater than the total number of showtimes available
        count = Math.Min(count, allShowtimes.Count);

        // Randomly select showtimes from the list
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(allShowtimes.Count); // Generate a random index
            randomShowtimes.Add(allShowtimes[index]); // Add the showtime at the random index to the list
            allShowtimes.RemoveAt(index); // Remove the selected showtime from the original list to avoid duplicates
        }

        return randomShowtimes;
    }

    // This method retrieves the showtimes for the provided movie
    public static List<DateTime> GetMovieShowtimes(Movie movie)
    {
        // Logic to retrieve showtimes for the provided movie
        // You would need to implement this method based on your data structure or source for showtimes
        // For example, if each movie object has a list of associated showtimes, you would return that list here
        // This is just a placeholder method
        if (movie is Action)
        {
            // Example: Retrieve showtimes for an Action movie
            // Replace this with your actual logic to retrieve showtimes
            return new List<DateTime>
            {
                DateTime.Now.Date.AddHours(10), // Example showtime at 10:00 AM today
                DateTime.Now.Date.AddHours(14), // Example showtime at 2:00 PM today
                DateTime.Now.Date.AddHours(18)  // Example showtime at 6:00 PM today
            };
        }
        else if (movie is Comedy)
        {
            // Example: Retrieve showtimes for a Comedy movie
            // Replace this with your actual logic to retrieve showtimes
            return new List<DateTime>
            {
                DateTime.Now.Date.AddHours(11), // Example showtime at 11:00 AM today
                DateTime.Now.Date.AddHours(15), // Example showtime at 3:00 PM today
                DateTime.Now.Date.AddHours(19)  // Example showtime at 7:00 PM today
            };
        }
        else if (movie is Horror)
        {
            // Example: Retrieve showtimes for a Horror movie
            // Replace this with your actual logic to retrieve showtimes
            return new List<DateTime>
            {
                DateTime.Now.Date.AddHours(12), // Example showtime at 12:00 PM today
                DateTime.Now.Date.AddHours(16), // Example showtime at 4:00 PM today
                DateTime.Now.Date.AddHours(20)  // Example showtime at 8:00 PM today
            };
        }
        else
        {
            // If the movie type is not recognized, return an empty list
            return new List<DateTime>();
        }
    }

    // This method prints the provided showtimes to the console
    public static void PrintShowtimes(List<DateTime> showtimes)
    {
        Console.WriteLine("Available Showtimes:");
        foreach (var showtime in showtimes)
        {
            Console.WriteLine(showtime.ToString("hh:mm tt"));
        }
    }
}
