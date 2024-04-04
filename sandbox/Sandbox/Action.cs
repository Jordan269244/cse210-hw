using System;


public class Action : Movie
{
    public Action(string title, string rating, TimeSpan length, string summary) : base(title, rating, length, summary)
    {

    }

    public override void PrintGenre()
    {
        Console.WriteLine("Genre: Action");
    }

    private static List<Movie> actionMovies = new List<Movie>
    {
        new Action("Die Hard", "R" , TimeSpan.FromMinutes(132), "An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles."),
        new Action("The Matrix", "R", TimeSpan.FromMinutes(136), "A computer hacker learns about the true nature of his reality and his role in the war against its controllers."),
        
    };
}