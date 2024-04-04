using System;


public abstract class Movie
{

    public string Title {get; set;}
    public  string Rating {get; set;}
    public TimeSpan Length {get; set;}
    public string Summary {get; set;}

    protected Movie(string title, string rating,TimeSpan Length, string summary)
    {
        Title = title;
        Rating = rating;
        Length = Length;
        Summary = summary;

    }
    public abstract void PrintGenre();


}