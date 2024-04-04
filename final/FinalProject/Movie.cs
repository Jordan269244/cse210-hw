using System;


public abstract class Movie
{

    public string _title {get; set;}
    public  string _rating {get; set;}
    public TimeSpan _length {get; set;}
    public string _summary {get; set;}

    protected Movie(string title, string rating,TimeSpan Length, string summary)
    {
        _title = title;
        _rating = rating;
        _length = Length;
        _summary = summary;

    }
    public abstract void PrintGenre();

    public string GetTitle()
    {
        return _title;
    }

    public string GetRating()
    {
        return _rating;
    }
    public TimeSpan GetLength()
    {
        return _length;
    }
    public string GetSummary()
    {
        return _summary;
    }


}