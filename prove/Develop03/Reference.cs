using System;
using System.Collections.Generic;
class Reference
{
    public string _book { get; }
    public int _chapter { get; }
    public int _startVerse { get; }
    public int _endVerse { get; }

    public Reference(string referenceText)
    {
        // Split the reference text by space, ':', '-', and '|'
        string[] _parts = referenceText.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

        if (_parts.Length < 3)
        {
            throw new FormatException("Invalid reference format. Expected format: Book Chapter:StartVerse[-EndVerse]");
        }

        // Parse book
        _book = _parts[0];

        // Parse chapter
        if (!int.TryParse(_parts[1], out int chapter))
        {
            throw new FormatException("Invalid chapter format. Chapter should be a number.");
        }
        _chapter = chapter;

        // Parse start verse
        if (!int.TryParse(_parts[2], out int startVerse))
        {
            throw new FormatException("Invalid start verse format. Start verse should be a number.");
        }
        _startVerse = startVerse;

        // Parse end verse (if available)
        int endVerse = startVerse;
        if (_parts.Length > 3 && !int.TryParse(_parts[3], out endVerse))
        {
            throw new FormatException("Invalid end verse format. End verse should be a number.");
        }
        _endVerse = _parts.Length > 3 ? endVerse : startVerse;
    }

    public override string ToString()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}