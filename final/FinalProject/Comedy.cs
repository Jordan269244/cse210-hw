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
        new Comedy("My Big Fat Greek Wedding", "PG" , TimeSpan.FromMinutes(113), "A young Greek woman's journey to navigate cultural differences and familial expectations as she falls in love with a non-Greek man."),
        new Comedy("Shrek", "PG", TimeSpan.FromMinutes(90), "An ogre named Shrek embarks on a quest to rescue Princess Fiona from a dragon-guarded tower so Lord Farquaad will remove all the fairytale creatures from his swamp."),
        new Comedy("Toy Story", "G",TimeSpan.FromMinutes(81),"A heartwarming tale of toys that come to life when humans aren't around. Woody, a pull-string cowboy doll, is threatened when a new spaceman action figure, Buzz Lightyear, arrives and becomes the new favorite toy."),
        new Comedy("Nacho Libre","PG",TimeSpan.FromMinutes(92),"Ignacio, a monastery cook, spends his free time dreaming of becoming a professional wrestler. To earn money for the orphanage where he works, Ignacio decides to don a mask and enter the ring as the luchador Nacho Libre."),
        //Summaries were given by ChatGPT
    };

}