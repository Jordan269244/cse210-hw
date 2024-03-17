using System;
using System.Collections.Generic;
using System.IO;

class Word
{
    public string Text { get; }
    public bool _isHidden { get; private set; }  // Property to indicate whether the word is hidden or not

    public Word(string text)
    {
        Text = text;
        _isHidden = false;  // By default, the word is not hidden
    }

    // Method to hide the word
    public void _hide()
    {
        _isHidden = true;
    }
}

