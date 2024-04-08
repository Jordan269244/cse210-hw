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

    public static List<Movie> actionMovies = new List<Movie>
    {
        new Action("Die Hard", "R" , TimeSpan.FromMinutes(132), "An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles."),
        new Action("The Matrix", "R", TimeSpan.FromMinutes(136), "A computer hacker learns about the true nature of his reality and his role in the war against its controllers."),
        new Action("Avengers: Endgame","PG-13",TimeSpan.FromMinutes(181),"After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in a final attempt to undo Thanos' actions and restore order to the universe."),
        new Action("Missions:Impossible - Fallout", "PG-13", TimeSpan.FromMinutes(147),"Ethan Hunt and his IMF team, along with some familiar allies, race against time after a mission goes wrong. They must stop a global catastrophe as nuclear weapons threaten to fall into the wrong hands.") 
    };
    //Summaries were given by ChatGPT
}