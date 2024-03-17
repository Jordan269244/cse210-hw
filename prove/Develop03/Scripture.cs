using System;
using System.Collections.Generic;
using System.IO;

class Scripture
{
    public Reference Reference { get; }
    public Passage Passage { get; }

    public Scripture(Reference reference, Passage passage)
    {
        Reference = reference;
        Passage = passage;
    }

    // Method to toggle visibility of the next word in the passage
    public void HideRandomWord()
    {
        Passage._HideRandomWord();
    }

    // Method to check if all words in the passage have been replaced with underscores
    public bool AllWordsReplaced()
    {
        return Passage._AllWordsReplaced();
    }

    public override string ToString()
    {
        return $"{Reference}: {Passage}";
    }
}