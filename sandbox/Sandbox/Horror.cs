using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Horror : Movie
{
    public Horror(string title, string rating, TimeSpan length, string summary) : base(title, rating, length, summary)
    {

    }

    public override void PrintGenre()
    {
        Console.WriteLine("Genre: Horror");
    }

    private static List<Movie> horrorMovies = new List<Movie>
        {
            new Horror("The Shining", "R", TimeSpan.FromMinutes(146), "A family heads to an isolated hotel for the winter where an evil spiritual presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future."),
            new Horror("Psycho", "R" , TimeSpan.FromMinutes(109), "A Phoenix secretary embezzles $40,000 from her employer's client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother."),
            
        };

}