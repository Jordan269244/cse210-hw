using System;


public class Comedy: Movie
{
    public Comedy(string title, string rating, TimeSpan length, string summary) : base(title, rating, length, summary)
    {

    }

    public override void PrintGenre()
    {
        Console.WriteLine("Genre: Comedy");
    }

    
    public static List<Movie> comedyMovies = new List<Movie>
    {
        new Comedy("My Big Fat Greek Wedding", "PG" , TimeSpan.FromMinutes(113), "A young Greek woman's journey to navigate cultural differences and familial expectations as she falls in love with a non-Greek man.")
    };

}